using Mukicik.Models;
using Mukicik.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mukicik.Views
{
    public partial class LoginPage : System.Web.UI.Page
    {
        UserRepo repo = new UserRepo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["user"] != null)
            {
                HttpCookie cookie = Request.Cookies["user"];
                if (!int.TryParse(cookie["id"], out int id))
                {
                    Response.Redirect("LoginPage.aspx");
                }

                User user = repo.GetUserById(id);

                if (user == null) return;

                Session["user"] = user;
            }

            if (Session["user"] != null)
            {
                Response.Redirect("HomePage.aspx");
            }
        }
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;
            if (email == "" || password == "")
            {
                return;
            }

            if (repo.GetUserByEmail(email) == null)
            {
                return;
            };

            User user = repo.GetUserByEmail(email);

            Session["user"] = user;

            if (RememberMeCheckBox.Checked)
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