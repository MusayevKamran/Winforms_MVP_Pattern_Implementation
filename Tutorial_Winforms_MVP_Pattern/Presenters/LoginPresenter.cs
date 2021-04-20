using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Tutorial_Winforms_MVP_Pattern.Interfaces;
using Tutorial_Winforms_MVP_Pattern.Models;

namespace Tutorial_Winforms_MVP_Pattern.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginForm _loginForm;
        public LoginPresenter(ILoginForm loginForm)
        {
            _loginForm = loginForm;
        }

        public void Login(object sender, EventArgs e)
        {
            var userName = _loginForm.User.UserName;
            var password = _loginForm.User.Password;

            CheckUser(userName, password);
            LoginUser(userName, password);
        }

        public void CheckUser(string userName, string password)
        {
            MessageBox.Show(userName + "Exist");

        }

        public void LoginUser(string userName, string password)
        {
            MessageBox.Show(userName + " logged in ");
        }


    }
}
