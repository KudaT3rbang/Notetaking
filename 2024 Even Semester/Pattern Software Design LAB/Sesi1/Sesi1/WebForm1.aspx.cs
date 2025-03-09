using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sesi1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string name = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            bool isMale = MaleRadioButton.Checked;

            if (name == "" || password == "")
            {
                WarningLabel.Text = "Please insert your username/password!";
                return;
            }
            else if (!name.EndsWith(".com"))
            {
                WarningLabel.Text = "Username must end with .com!";
                return;
            }

            Console.WriteLine("Success!");
            WarningLabel.Text = "Success";
            WarningLabel.ForeColor = System.Drawing.Color.Green;
        }
    }
}