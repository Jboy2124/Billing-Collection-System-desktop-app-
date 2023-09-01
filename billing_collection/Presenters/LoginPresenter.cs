using billing_collection.Repository.Login;
using billing_collection.Views.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billing_collection.Presenters
{
    public class LoginPresenter
    {
        private readonly LoginRepoInterface _repo;
        private readonly LoginInterface _view;

        public LoginPresenter(LoginInterface view, LoginRepoInterface repo) { 
            _view = view;
            _repo = repo;
            _view.Login += OnLogin;
        }

        private async void OnLogin(object sender, EventArgs e)
        {
            try
            {
                string user = _view.Username;
                string password = _view.Password;

                bool access = await _repo.Authentication(user, password);
                if (access)
                {
                    _view.ErrorMessage("Access Granted");
                }
                else {
                    _view.ErrorMessage("Access Denied");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

   
}
