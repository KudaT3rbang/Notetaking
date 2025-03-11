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
    public partial class LoginPage : System.Web.UI.Page
    {
        UserFactory factory = new UserFactory();
        UserRepository repo = new UserRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkToRegisterButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            bool isCheckedLogin = RememberMeCheckBox.Checked;

            if (username == "" || password == "")
            {
                return;
            }

            User user = repo.GetUserByUsername(username);
            if (user == null)
            {
                return;
            }

            if(user.Password != password)
            {
                return;
            }

            Session["user"] = user;

            if(isCheckedLogin)
            {
                HttpCookie cookie = new HttpCookie("user");
                cookie["id"] = user.UserId.ToString();
                cookie.Expires = DateTime.Now.AddDays(1);

                Response.Cookies.Add(cookie);
            }

            Response.Redirect("HomePage.aspx");
        }
    }
}