using Sesi3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sesi3.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        Database1Entities1 db = new Database1Entities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            if (username == "" || password == "")
            {
                return;
            }

            user user1 = new user()
            {
                Username = username,
                Password = password,
            };
            user user = user1;

            db.users.Add(user);
            db.SaveChanges();

            Response.Redirect("LoginPage.aspx");
        }
    }
}