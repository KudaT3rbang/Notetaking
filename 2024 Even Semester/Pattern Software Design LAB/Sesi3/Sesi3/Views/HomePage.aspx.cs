using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sesi3.Views
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Session.Abandon();
                Session.RemoveAll();
            }

            if (Request.Cookies["user"] != null)
            {
                HttpCookie cookie = Request.Cookies["user"];
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
            }

            Response.Redirect("LoginPage.aspx");
        }
    }
}