using Autorization.DAL;
using Autorization.Entities;
using Autorization.Forms;
using Autorization.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autorization
{
    public partial class MainForm : Form
    {
        #region FIELDS
        static List<User> users;
        Registration formReg;
        MainAppForm formApp;
        RecoveryPasswordForm formRecov;
        #endregion        

        public MainForm()
        {
            InitializeComponent();           
        }

        #region EVENTHANDLERS

        private void MainForm_Load(object sender, EventArgs e)
        {
            users = Repository.OpenBase();
            tbLog.GotFocus += new System.EventHandler(this.TextBox_GotFocus);
            tbPas.GotFocus += new System.EventHandler(this.TextBox_GotFocus);
            tbLog.LostFocus += new System.EventHandler(this.TextBox_LostFocus);
            tbPas.LostFocus += new System.EventHandler(this.TextBox_LostFocus);
        }

        private void linkLRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formReg = new Registration();
            formReg.Visible = false;
            formReg.ShowDialog();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            users = Repository.OpenBase();            
            if (!TextBoxValidator.IsTextEmpty(tbLog) && !TextBoxValidator.IsTextEmpty(tbPas))
            {
                pbMain.Visible = true;
                lbInfoProgBar.Text = "Идет проверка.. Подождите";
                lbInfoProgBar.Visible = true;
                for (int i = 0; i <= (pbMain.Maximum / pbMain.Step); i++)
                {
                    Thread.Sleep(500);
                    if ((pbMain.Value + pbMain.Step) <= pbMain.Maximum)
                        pbMain.Value += pbMain.Step;
                }

                User user = new User();
                int j = GetCurUser(user);
                if (j != -1)
                {
                    formApp = new MainAppForm(users[j]);
                    formApp.ShowDialog();
                    ClearInfoControl();
                }
                else
                    lbInfoProgBar.Text = "Ошибка, в доступе отказано...";
            }
        }

        private void TextBox_GotFocus(Object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb == tbLog)
            {
                if (tbLog.Text.Equals("Имя пользователя"))
                {
                    tbLog.Text = String.Empty;
                    tbLog.ForeColor = Color.Black;
                }
            }
            else if (tb == tbPas)
            {
                if (tbPas.Text.Equals("Пароль"))
                {
                    tbPas.Text = String.Empty;
                    tbPas.PasswordChar = '*';
                    tbPas.ForeColor = Color.Black;
                }
            }
        }

        void TextBox_LostFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb == tbLog)
            {
                if (tbLog.Text.Equals(String.Empty))
                {
                    tbLog.Text = "Имя пользователя";
                    tbLog.ForeColor = Color.Gray;
                }
            }
            else if (tb == tbPas)
            {
                if (tbPas.Text.Equals(String.Empty))
                {
                    tbPas.Text = "Пароль";
                    tbPas.PasswordChar = '\0';
                    tbPas.ForeColor = Color.Gray;
                }
            }
        }

        private void tbLogPas_TextChanged(object sender, EventArgs e)
        {
            tbCheckData.Visible = false;
            ClearInfoControl();
        }

        private void linkLIsForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            users = Repository.OpenBase();
            if (!TextBoxValidator.IsTextEmpty(tbLog))
            {
                User user = new User() { Log = tbLog.Text };
                int j = -1;
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Log.Equals(user.Log))
                    {
                        j = i;
                        break;
                    }
                }
                if (j != -1)
                {
                    formRecov = new RecoveryPasswordForm(users[j]);
                    if (DialogResult.OK == formRecov.ShowDialog())
                        Repository.SaveToBase(users);
                }
                else
                    MessageBox.Show("В системе нет пользователя с таким логином");
            }
            ClearInfoControl();
        }
        #endregion

        #region MYMETHODS
        /// <summary>
        /// Прячет BrogressBar и Label отвечающие за имитацию проверки
        /// сбрасывает свойство Value у ProgressBar в начальное значение
        /// </summary>
        private void ClearInfoControl()
        {
            pbMain.Visible = false;
            pbMain.Value = 0;
            lbInfoProgBar.Visible = false;
        }

        /// <summary>
        /// Производит поиск пользователя по введенному логину и паролю
        /// </summary>
        /// <returns>индекс пользователя в коллекции, или
        /// -1, если пользователя с таким логином и паролем не найдено</returns>
        private int GetCurUser(User user)
        {
            bool flag = false;
            int index = -1;
            user = new User() { Log = tbLog.Text, Pass = tbPas.Text };
            for (int i = 0; i < users.Count; i++)
            {
                if (users.Contains(user))
                {
                    index = users.IndexOf(user);
                    flag = true;
                    break;
                }
            }
            if (flag == false)
                tbCheckData.Visible = true;

            return index;
        }               
        #endregion        
    }
}
