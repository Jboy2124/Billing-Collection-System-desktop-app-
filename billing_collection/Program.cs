using billing_collection.Presenters;
using billing_collection.Repository.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billing_collection.Views.Forms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginRepoInterface _repo = new LoginRepoClass();
            LoginInterface _view = new LoginForm();
            LoginPresenter presenter = new LoginPresenter(_view, _repo);

            Application.Run(_view as Form);
        }
    }
}
