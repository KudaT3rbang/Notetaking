using Sesi3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sesi3.Views
{
    public partial class LoginPage : System.Web.UI.Page
    {
        Database1Entities1 db = new Database1Entities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["user"] != null) // Changed from Response to Request
            {
                HttpCookie cookie = Request.Cookies["user"]; // Changed from Response to Request
                if (!int.TryParse(cookie["id"], out int id))
                {
                    Response.Redirect("LoginPage.aspx");
                }

                user user = db.users.Find(id);

                if (user == null) return;

                Session["user"] = user;
            }

            if (Session["user"] != null)
            {
                Response.Redirect("HomePage.aspx");
            }
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            bool rememberMe = RememberMeCheckBox.Checked;

            if (username == "" || password == "")
            {
                return;
            }

            user user = db.users.FirstOrDefault(u => u.Username == username);
            if (user == null) return;
            if (user.Password != password) return;

            Session["user"] = user;

            if (rememberMe)
            {
                HttpCookie cookie = new HttpCookie("user");
                cookie["id"] = user.Id.ToString();
                cookie.Expires = DateTime.Now.AddDays(1);

                Response.Cookies.Add(cookie);
            }

            Response.Redirect("HomePage.aspx");
        }
    }
}