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

namespace Autorization.Forms
{
    public partial class RecoveryPasswordForm : Form
    {
        #region FIELDS
        private User user;
        private Dictionary<ErrorProvider, bool> epList;
        private static string EmailPattern = @"\w+@\w+[.]\w+";
        #endregion

        public User User
        {
            get { return user; }
            set { user = value; }
        }

        #region CONSTRUCTORS
        public RecoveryPasswordForm()
            : this(new User())
        {
            //InitializeComponent();
        }

        public RecoveryPasswordForm(User user)
        {
            InitializeComponent();
            this.user = user;
            epList = new Dictionary<ErrorProvider, bool>();
            epList[epEmailForRecov] = false;
            epList[epNewPasForRecov] = false;
            epList[epRepeatNewPasForRecov] = false;
        }
        #endregion

        #region EVENTHANDLERS
        private void RecoveryPasswordForm_Load(object sender, EventArgs e)
        {
            epEmailForRecov.SetError(tbEmailForReset, "обязательное поле");
            epNewPasForRecov.SetError(tbNewPassReset, "обязательное поле");
            epRepeatNewPasForRecov.SetError(tbRepeatNewPasReset, "обязательное поле");
        }

        private void btnCancelRecov_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOkRecov_Click(object sender, EventArgs e)
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
                if (!tbEmailForReset.Text.Equals(user.Email))
                    MessageBox.Show("Введен неверный email. Пожалуйста, проверьте");
                else
                {
                    if (tbNewPassReset.Text.Equals(tbRepeatNewPasReset.Text))
                        user.Pass = tbNewPassReset.Text;
                    this.DialogResult = DialogResult.OK;
                }
            }
            
        }

        private void tbTextBox_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb == tbEmailForReset)
            {
                if (Regex.IsMatch(tbEmailForReset.Text, EmailPattern))
                {
                    epEmailForRecov.Icon = Properties.Resources.Ok;
                    epList[epEmailForRecov] = true;
                }
                else
                    epEmailForRecov.SetError(tbEmailForReset, "Некорректный email. Пожалуйста, проверьте");
            }
            else if (tb == tbNewPassReset)
            {
                if (tbNewPassReset.Text.Length < 6)
                    epNewPasForRecov.SetError(tbNewPassReset, "пароль должен быть не менее 6 символов");
                else
                {
                    epNewPasForRecov.Icon = Properties.Resources.Ok;
                    epList[epNewPasForRecov] = true;
                }                
            }
            else if (tb == tbRepeatNewPasReset)
            {
                if (tbNewPassReset.Text.Equals(tbRepeatNewPasReset.Text))
                {
                    epRepeatNewPasForRecov.Icon = Properties.Resources.Ok;
                    epList[epRepeatNewPasForRecov] = true;
                }
                else
                    epRepeatNewPasForRecov.SetError(tbRepeatNewPasReset, "Пароли не совпадают. Пожалуйста, проверьте");
            }
        }
        #endregion        
    }
}
