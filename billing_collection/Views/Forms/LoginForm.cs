using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billing_collection.Views.Forms
{
    public partial class LoginForm : Form, LoginInterface
    {
        public LoginForm()
        {
            InitializeComponent();
            btnLogin.Click += delegate { Login?.Invoke(this, EventArgs.Empty); };
        }

        public string Username => txtUsername.Text;

        public string Password => txtPassword.Text;

        public event EventHandler Login;

        public void ErrorMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void IsAccessGranted()
        {
            MainForm main = new MainForm();
            this.Hide();
            main.Show();
        }
    }
}
