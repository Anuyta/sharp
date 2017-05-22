using Autorization.DAL;
using Autorization.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autorization
{
    public partial class Registration : Form
    {
        #region FIELDS
        private static List<User> users;
        private Dictionary<ErrorProvider, bool> epList;
        private static string EmailPattern = @"\w+@\w+[.]\w+";        
        #endregion

        public Registration()
        {
            InitializeComponent();
            epList = new Dictionary<ErrorProvider, bool>();
            epList.Add(epLogin, false);
            epList.Add(epPas, false);
            epList.Add(epRepeatPas, false);
            epList.Add(epEmail, false);
        }

        #region EVENTHANDLERS
        private void Registration_Load(object sender, EventArgs e)
        {
            epLogin.SetError(tbNewLog, "обязательное поле");
            epPas.SetError(tbNewPas, "обязательное поле");
            epRepeatPas.SetError(tbRepeatPas, "обязательное поле");
            epEmail.SetError(tbNewEmail, "обязательное поле");
            users = Repository.OpenBase();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (var eps in epList)
            {
                if (eps.Value == true)
                    count++;
            }
            if (count != epList.Count)
                MessageBox.Show("Заполните все обязательные поля");
            else
            {
                User user = new User();
                user.Log = tbNewLog.Text;
                user.Pass = tbNewPas.Text;
                user.Name = tbNewName.Text;
                user.Surname = tbNewSurname.Text;
                user.Email = tbNewEmail.Text;

                users.Add(user);
                Repository.SaveToBase(users);

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbTextBox_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb == tbNewLog)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Log == tbNewLog.Text)
                    {
                        epLogin.SetError(tbNewLog, "Такой логин уже существует");
                        return;
                    }
                }
                epLogin.Icon = Properties.Resources.Ok;
                epList[epLogin] = true;
            }
            else if (tb == tbNewPas)
            {
                if (tbNewPas.Text.Length < 6)
                    epPas.SetError(tbNewPas, "пароль должен быть не менее 6 символов");
                else
                {
                    epPas.Icon = Properties.Resources.Ok;
                    epList[epPas] = true;
                }
            }
            else if (tb == tbRepeatPas)
            {
                if (tbNewPas.Text.Equals(tbRepeatPas.Text))
                {
                    epRepeatPas.Icon = Properties.Resources.Ok;
                    epList[epRepeatPas] = true;
                }
                else
                    epRepeatPas.SetError(tbRepeatPas, "Пароли не совпадают. Пожалуйста, проверьте");
            }
            else if (tb == tbNewEmail)
            {
                if (Regex.IsMatch(tbNewEmail.Text, EmailPattern))
                {
                    epEmail.Icon = Properties.Resources.Ok;
                    epList[epEmail] = true;
                }
                else
                    epEmail.SetError(tbNewEmail, "Некорректный email. Пожалуйста, проверьте");
            }
        }
        #endregion       
    }
}
