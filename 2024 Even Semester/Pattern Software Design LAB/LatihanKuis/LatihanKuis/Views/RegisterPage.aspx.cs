using LatihanKuis.Factory;
using LatihanKuis.Models;
using LatihanKuis.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LatihanKuis.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        UserFactory factory = new UserFactory();
        UserRepository repo = new UserRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkToLoginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            if (username == "" || password == "")
            {
                WarningLabel.Text = "Please Insert Your Username/Password!";
                WarningLabel.ForeColor = System.Drawing.Color.Red;
                return;
            }

            repo.InsertUser(factory.CreateUser(username, password));
            WarningLabel.Text = "Account Created!";
            WarningLabel.ForeColor = System.Drawing.Color.Green;
        }
    }
}