using Autorization.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autorization.Forms
{
    public partial class MainAppForm : Form
    {
        #region CONSTRUCTORS 
        public MainAppForm() : this (new User())
        {
            //InitializeComponent();
        }

        public MainAppForm(User user)
        {
            InitializeComponent();
            tbPersonalDate.Text = user.Surname + " " + user.Name;
        }
        #endregion
    }
}
