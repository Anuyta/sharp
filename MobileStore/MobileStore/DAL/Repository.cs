using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MobileStore
{
    static class Repository
    {
        static BindingList<Phone> phones;
        static BindingList<Options> options;

        static Repository()
        {
            //phones = new BindingList<Phone>()
            //{
            //    new Phone() {Model = "Samsung", Os = "Android", Price = 150, PathPicture = "pic/samsung.jpg", Proc = "2.2", 
            //        Options = new List<Options>() {
            //            new Options() { Name = "WiFi" }, 
            //            new Options() { Name = "GPS" },
            //            new Options() { Name = "TV" },
            //            new Options() { Name = "MultiTouch"},
            //            new Options() { Name = "SMS/MMS" }}},

            //    new Phone() {Model = "LG", Os = "Android", Price = 250, PathPicture = "pic/lg.jpg", Proc = "4.5", 
            //        Options = new List<Options>() {
            //            new Options() { Name = "WiFi" }, 
            //            new Options() { Name = "TV" },
            //            new Options() { Name = "SMS/MMS" }}},
            //    new Phone() {Model = "Sony", Os = "Android", Price = 270, PathPicture = "pic/sony.jpg", Proc = "3.2",
            //        Options = new List<Options>() {
            //            new Options() { Name = "MultiTouch" },
            //            new Options() { Name = "SMS/MMS" }}},

            //    new Phone() {Model = "Samsung", Os = "Ios", Price = 150, PathPicture = "pic/samsung2.jpg", Proc = "2.2",
            //        Options = new List<Options>() {
            //            new Options() { Name = "WiFi" }, 
            //            new Options() { Name = "MultiTouch"},
            //            new Options() { Name = "SMS/MMS" }}}
            //};

            //options = new BindingList<Options>()
            //{
            //    new Options() { Name = "WiFi" },
            //    new Options() { Name = "GPS" },
            //    new Options() { Name = "TV" },
            //    new Options() { Name = "MultiTouch" },
            //    new Options() { Name = "SMS/MMS" }
            //};            
        }

        #region METHODS
        /// <summary>
        /// Создает xml-файл со списком телефонов
        /// </summary>
        public static void CreateFilePhones()
        {
            using (FileStream file = new FileStream("phones.xml", FileMode.Create))
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(BindingList<Phone>));
                xmlFormat.Serialize(file, phones);
            }
        }

        /// <summary>
        /// Выводит в listBox список телефонов из файла
        /// </summary>
        /// <returns>список телефонов</returns>
        public static BindingList<Phone> InitLbPhonesFromFile()
        {
            using (FileStream file = new FileStream("phones.xml", FileMode.Open))
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(BindingList<Phone>));
                phones = ((BindingList<Phone>)xmlFormat.Deserialize(file));
            }
            return phones;
        }

        /// <summary>
        /// Создает xml-файл со списком опций
        /// </summary>
        public static void CreateFileOptions()
        {
            using (FileStream file = new FileStream("options.xml", FileMode.Create))
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(BindingList<Options>));
                xmlFormat.Serialize(file, options);
            }
        }

        /// <summary>
        /// Выводит в CheckedListBox список опций из файла
        /// </summary>
        /// <returns>список опций</returns>
        public static BindingList<Options> InitClbOptionsFromFile()
        {
            using (FileStream file = new FileStream("options.xml", FileMode.Open))
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(BindingList<Options>));
                options = ((BindingList<Options>)xmlFormat.Deserialize(file));
            }
            return options;
        }
        #endregion
        
    }
}
