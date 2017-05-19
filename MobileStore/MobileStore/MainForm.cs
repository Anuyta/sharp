using MobileStore.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MobileStore
{
    public partial class MainForm : Form
    {
        static BindingList<Phone> phones;
        static BindingList<Options> options;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            phones = Repository.InitLbPhonesFromFile();
            //options = Repository.CreateOptions();
            //Repository.CreateFileOptions();
            options = Repository.InitClbOptionsFromFile();
            lbListPhones.DataSource = phones;
            clbOptions.DataSource = options;
            Phone selPhone = (Phone)lbListPhones.SelectedItem;
            if (lbListPhones.SelectedItem != null)
                CheckedUnchekedClb(selPhone);            
                
        }

        #region METODS FOR CLASS
        /// <summary>
        ///Инициализация checkedListBox для конкретного телефона
        /// </summary>
        /// <param name="phone"></param>
        private void CheckedUnchekedClb(Phone phone)
        {
            for (int i = 0; i < options.Count; i++)
            {
                int j = 0;
                bool flag = false;
                while (j < phone.Options.Count)
                {
                    if (options[i].Equals(phone.Options[j]))
                    {
                        clbOptions.SetItemChecked(i, true);
                        flag = true;
                    }
                    j++;
                }
                if (flag == false)
                    clbOptions.SetItemChecked(i, false);
            }
        }
        
        /// <summary>
        /// Создаёт копию телефона
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        private static Object DeepC1one(Object original)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, original);
                stream.Position = 0;
                return formatter.Deserialize(stream);
            }
        }
        #endregion

        #region METODS FOR EVENTS
        
        /// <summary>
        /// Удаляет выбранный элемент списка из ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDelCur_Click(object sender, EventArgs e)
        {
            if (lbListPhones.SelectedItem != null)
            {
                Phone selPhopne = (Phone)lbListPhones.SelectedItem;
                phones.Remove(selPhopne);
                if (phones.Count > 0)
                    lbListPhones.SelectedItem = phones[0];
            }
            Repository.CreateFilePhones();
        }

        /// <summary>
        /// Инициализирует listBox списком телефона из файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRead_Click(object sender, EventArgs e)
        {
            phones = Repository.InitLbPhonesFromFile();
            lbListPhones.DataSource = phones;
        }

        /// <summary>
        /// Очищает listBox со списком телефонов, но не удаляет их из файла, необходимо нажать сохранить изменения
        /// в tabControl остаются все значения, что позволяет лего добавить новый телефон
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClearAll_Click(object sender, EventArgs e)
        {
            lbListPhones.DataSource = null;
            phones.Clear();
            options.Clear();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Repository.CreateFilePhones();
        }

        /// <summary>
        /// Отображение параметров выбранного телефона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbListPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbListPhones.SelectedItem != null)
            {
                Phone selPhone = (Phone)lbListPhones.SelectedItem;
                tbModel.Text = selPhone.Model;
                tbOs.Text = selPhone.Os;
                tbPrice.Text = selPhone.Price.ToString();
                tbProc.Text = selPhone.Proc;
                if (selPhone.PathPicture != string.Empty)
                    pbImagePhone.ImageLocation = selPhone.PathPicture;
                else
                    pbImagePhone.Image = Properties.Resources.phone;

                lbOptions.DisplayMember = "Name";
                lbOptions.DataSource = selPhone.Options;
                lbOptions.SelectedIndex = -1;

                tbEditModel.Text = selPhone.Model;
                tbEditOs.Text = selPhone.Os;
                tbEditProc.Text = selPhone.Proc;
                tbEditPrice.Text = selPhone.Price.ToString();
                tbEditPict.Text = selPhone.PathPicture;

                CheckedUnchekedClb(selPhone);
            }
        }

        /// <summary>
        /// Добавляет новую опцию в checkedListBox и в xml-файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddOption_Click(object sender, EventArgs e)
        {
            if (!TextBoxValidators.IsTextEmpty(tbNameOption))
            {
                if (lbListPhones.SelectedItem != null)
                {
                    Phone selPhone = (Phone)lbListPhones.SelectedItem;

                    Options newOpt = new Options() { Name = tbNameOption.Text };
                    if (!options.Contains(newOpt))
                    {
                        options.Add(newOpt);
                        Repository.CreateFileOptions();
                        selPhone.Options.Add(newOpt);
                    }
                    else
                        MessageBox.Show("Такая опция уже существует!");

                    CheckedUnchekedClb(selPhone);
                }
            }
        }

        /// <summary>
        /// Добавляет новый телефон в список на основании выбранного или оставшихся данных от последнего выбранного телефона, если все из списка удалены
        /// сохраняет изменения в выбранном телефоне
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSaveChanges_AddNewPhone_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Phone selPhone;
            if (lbListPhones.SelectedItem != null)
                selPhone = (Phone)lbListPhones.SelectedItem;
            else
                selPhone = new Phone();
            selPhone.Model = tbEditModel.Text;
            selPhone.Os = tbEditOs.Text;
            selPhone.Proc = tbEditProc.Text;
            if (tbEditPict.Text != string.Empty)
                selPhone.PathPicture = tbEditPict.Text;
            else
                selPhone.PathPicture = @"pic\phone.png";
            selPhone.Options.Clear();
            if (tbEditPrice.Text != string.Empty)
                selPhone.Price = Decimal.Parse(tbEditPrice.Text);
            for (int i = 0; i < clbOptions.Items.Count; i++)
            {
                if (clbOptions.GetItemChecked(i))
                    selPhone.Options.Add(new Options() { Name = clbOptions.Items[i].ToString() });
            }
            if (btn == btSaveChanges)
            {
                Repository.CreateFilePhones();
                phones = Repository.InitLbPhonesFromFile();
                lbListPhones.DataSource = phones;
            }
            if (btn == btAddNewPhone)
            {
                Phone newPhone = new Phone();
                newPhone = (Phone)DeepC1one(selPhone);
                phones.Add(newPhone);
                if (phones.Count > 1)
                    lbListPhones.SelectedIndex = phones.Count - 1;
                lbListPhones.DataSource = phones;
            }

            Repository.CreateFilePhones();
        }
        
        /// <summary>
        /// Очищает все поля для ввода и checledListBox на вкладке редактирования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEditClearAll_Click(object sender, EventArgs e)
        {
            tbEditModel.Text = string.Empty;
            tbEditOs.Text = string.Empty;
            tbEditPict.Text = string.Empty;
            tbEditPrice.Text = string.Empty;
            tbEditProc.Text = string.Empty;
            for (int i = 0; i < options.Count; i++)
                clbOptions.SetItemChecked(i, false);
        }

        /// <summary>
        /// Удаляет существующую опцию из checkedListBox и из xml-файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDelOption_Click(object sender, EventArgs e)
        {
            if (lbListPhones.SelectedItem != null)
            {
                if (clbOptions.SelectedItem != null)
                {
                    Phone selPhone = (Phone)lbListPhones.SelectedItem;
                    options.RemoveAt(clbOptions.SelectedIndex);
                    Repository.CreateFileOptions();
                    CheckedUnchekedClb(selPhone);
                }
            }
        }
        #endregion                
    }
}
