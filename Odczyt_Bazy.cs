using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;

namespace Projekt_na_zaliczenie
{

    class Odczyt_Bazy
    {
        ObservableCollection<BazaDanych> baza { get; set; }






        public void odczytaj()
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".xml";
            dlg.Filter = "XML documents (.xml)|*.xml";

            Nullable<bool> result = dlg.ShowDialog();
            string filename = "";
            if (result == true)
            {
                filename = dlg.FileName;
            }

            if (File.Exists(filename))
            {
                XmlFileToList(filename);
            }
            else
            {
                MessageBox.Show(@"Such file doesn't exist");
            }
        }

        private void XmlFileToList(string filename)
        {
            using (var sr = new StreamReader(filename))
            {
                var deserializer = new XmlSerializer(typeof(ObservableCollection<BazaDanych>));
                ObservableCollection<BazaDanych> tmpList = (ObservableCollection<BazaDanych>)deserializer.Deserialize(sr);
                foreach (var item in tmpList)
                {
                    baza.Add(item);
                }
            }
        }

        public void zapisz()
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Characters"; // Default file name
            dlg.DefaultExt = ".xml";
            dlg.Filter = "XML documents (.xml)|*.xml";

            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filePath = dlg.FileName;

                ListToXmlFile(filePath);
            }
        }

        private void ListToXmlFile(string filePath)
        {
            using (var sw = new StreamWriter(filePath))
            {
                var serializer = new XmlSerializer(typeof(ObservableCollection<BazaDanych>));
                serializer.Serialize(sw, baza);
            }
        }


    }
}
