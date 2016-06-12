using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Serialization;

namespace Projekt_na_zaliczenie
{
    /// <summary>
    /// Interaction logic for Gra.xaml
    /// </summary>
    public partial class Gra : Window
    {
        ObservableCollection<BazaDanych> baza { get; set; }
        Random rand = new Random();

        public string odp { get; set; }
        public int x { get; set; }

        public class lista
        {
            public string kwota { get; set; }
        }

        public Gra()
        {
            InitializeComponent();
            wczytaj_baze();
            this.win_lista.SelectedIndex = 15;
            generuj_viev();
            button_label();


        }
        #region Koła_Ratunkowe_Buttons
        private void pol_na_pol_Click(object sender, RoutedEventArgs e)
        {
            var c = Brushes.Gold;

            if (MessageBox.Show("Czy na pewno chcesz użyć koła ratunkowego 50% / 50% ?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                int tmp = 0;
                if (odp != "A")
                {
                    tmp = +1;
                    A.IsEnabled = false;
                }

                if (odp != "B")
                {
                    tmp += 1;
                    B.IsEnabled = false;
                    B.Background = c;
                }

                if (odp != "C" && tmp < 2)
                {
                    D.IsEnabled = false;
                    D.Background = c;
                }

                pol_na_pol.IsEnabled = false;
            }
            else
            {
                pol_na_pol.Background = Brushes.Blue;
            }
        }

        private void telefon_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz użyć koła ratunkowego TELEFON DO PRZYJACIELA ?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Wydaje mi się ze poprawna odpowiedz to " + odp);
                telefon.IsEnabled = false;
            }
            else
            {
                telefon.Background = Brushes.Blue;
            }
        }

        private void pytanie_do_publicznosc_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz użyć koła ratunkowego PYTANIE DO PUBLICZNOSCI ?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                string A = "";
                pytanie_do_publicznosc.IsEnabled = false;
                foreach (var item in Enum.GetValues(typeof(sprawdz_odp)))
                {
                    if (item.ToString() == odp)
                    {
                        A += "Odpowiedz " + item + "-> 64% \n";
                    }
                    else
                    {
                        A += "Odpowiedz " + item + "-> 12% \n";
                    }
                }
                MessageBox.Show(A);
            }
            else
            {
                pytanie_do_publicznosc.Background = Brushes.Blue;
            }
        }
        #endregion

        private void XmlFileToList(string filename)
        {
            using (var serialize = new StreamReader(filename))
            {
                var deserializer = new XmlSerializer(typeof(ObservableCollection<BazaDanych>));
                ObservableCollection<BazaDanych> tmpList = (ObservableCollection<BazaDanych>)deserializer.Deserialize(serialize);
                foreach (var item in tmpList)
                {
                    baza.Add(item);
                }
            }
        }

        public void wczytaj_baze()
        {
            try
            {
                baza = new ObservableCollection<BazaDanych>();
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("http://pg-eti14.cba.pl/baza.xml", @"..\..\baza.xml");
                }
                XmlFileToList(@"..\..\baza.xml");
            }
            catch (Exception)
            {
                MessageBox.Show("BRAK POŁĄCZENIA Z BAZĄ");
            }
        }

        public void generuj_viev()
        {
            int z = 1;
            List<lista> wygrana = new List<lista>();

            foreach (wygrana_enum win in Enum.GetValues(typeof(wygrana_enum)))
            {
                wygrana.Add(new lista() { kwota = (z + "." + "   " + (int)win + " $") });
                z += 1;
            }
            wygrana.Reverse();
            win_lista.ItemsSource = wygrana;

        }
        public void button_label()
        {
            var button_1 = baza.ElementAt(x).wariant_A;
            var button_2 = baza.ElementAt(x).wariant_B;
            var button_3 = baza.ElementAt(x).wariant_C;
            var button_4 = baza.ElementAt(x).wariant_D;
            var question = baza.ElementAt(x).pytanie;
            odp = baza.ElementAt(x).odpowiedz;
            A.IsEnabled = true;
            B.IsEnabled = true;
            C.IsEnabled = true;
            D.IsEnabled = true;

            A.Content = button_1;
            B.Content = button_2;
            C.Content = button_3;
            D.Content = button_4;
            Pytanie.Content = question;
        }

        private void game_over()
        {
            int gg = 0;
            if (this.win_lista.SelectedIndex <= 5)
            {
                gg = 32000;
            }
            else if(this.win_lista.SelectedIndex <= 10)
            {
                gg = 1000;
            }
            MessageBox.Show("GAME OVER \n" + "POPRAWNA ODOWIEDZ TO: " + odp + "\n WYGRAŁEŚ  " + gg + "$");
            MainWindow x = new MainWindow();
            this.Hide();
            x.Show();
        }
        #region Button_Mouse
        private void A_Click(object sender, RoutedEventArgs e)
        {
            xxx(sprawdz_odp.A.ToString());
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            xxx(sprawdz_odp.B.ToString());
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            xxx(sprawdz_odp.C.ToString());
        }

        private void D_Click(object sender, RoutedEventArgs e)
        {
            xxx(sprawdz_odp.D.ToString());
        }
        #endregion

        public void xxx(string spr)
        {
            if (spr == odp)
            {
                this.win_lista.SelectedIndex -= 1;
                if (this.win_lista.SelectedIndex == -1)
                {
                    MessageBox.Show("WYGRAŁEŚ MILION");
                    this.Hide();
                    MainWindow form = new MainWindow();
                    form.Show();
                }
                baza.RemoveAt(x);
                x = rand.Next(baza.Count - 1);
                button_label();
            }
            else
            {
                game_over();
            }
        }
    }
}

