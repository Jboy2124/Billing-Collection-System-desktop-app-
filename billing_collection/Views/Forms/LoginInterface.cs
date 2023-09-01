using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billing_collection.Views.Forms
{
    public interface LoginInterface
    {
        event EventHandler Login;
        string Username { get; }
        string Password { get; }
        void ErrorMessage(string message);
        void IsAccessGranted();

    }
}
