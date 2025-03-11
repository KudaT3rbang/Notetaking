using Mukicik.Factories;
using Mukicik.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mukicik.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        UserFactory factory = new UserFactory();
        UserRepo repo = new UserRepo();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text;
            string name = NameTextBox.Text;
            string password = PasswordTextBox.Text;
            string passwordConfirm = ConfirmPasswordTextBox.Text;
            string isMale = MaleRadioButton.Checked ? "Male" : "Female";
            DateTime date = DobCalendar.SelectedDate;

            if (email == "" || name == "" || password == "")
            {
                ChangeLabelContent("Please Fill In The Form!", System.Drawing.Color.Red);
                return;
            }

            if (password != passwordConfirm)
            {
                ChangeLabelContent("Your Confirmation Password Is Incorrect", System.Drawing.Color.Red);
                return;
            }

            if (ConfirmationCheckBox.Checked == false)
            {
                ChangeLabelContent("Please Accept Terms And Agreement!", System.Drawing.Color.Red);
                return;
            }

            repo.InsertUser(factory.CreateUser(name, email, password, isMale, date, null));
            ChangeLabelContent("Account Successfully Created!", System.Drawing.Color.Green);
        }

        protected void DobCalendar_SelectionChanged(object sender, EventArgs e)
        {
            DobText.Text = DobCalendar.SelectedDate.ToString();
        }

        protected void ChangeLabelContent(string value, System.Drawing.Color color)
        {
            WarningLabel.Text = value;
            WarningLabel.ForeColor = color;
        }
    }
}