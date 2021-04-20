using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tutorial_Winforms_MVP_Pattern.Interfaces;
using Tutorial_Winforms_MVP_Pattern.Models;
using Tutorial_Winforms_MVP_Pattern.Presenters;

namespace Tutorial_Winforms_MVP_Pattern.Forms
{
    public partial class FormLogin : Form, ILoginForm
    {
        private User _user;
        public event EventHandler Login;
        private LoginPresenter _presenter;
        public FormLogin()
        {
            _user = new User();
            InitializeComponent();
        }

        public User User
        {
            get
            {
                _user.UserName = uxUserNameTextBox.Text;
                _user.Password = uxPasswordTextBox.Text;

                return _user;
            }
            set
            {
                _user = value;
                if (_user == null) return;

                uxUserNameTextBox.Text = _user.UserName;
                uxPasswordTextBox.Text = _user.Password;

            }
        }

        private void uxLoginButton_Click(object sender, EventArgs e)
        {
            _presenter = new LoginPresenter(this);

            Login +=_presenter.Login;

            Login?.Invoke(sender, e);
        }
    }
}
