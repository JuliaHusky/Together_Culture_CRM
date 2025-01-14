using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BeaversCRM_1.BurgerMenuButtons
{
    public partial class LogOutButton : UserControl
    {
        public LogOutButton()
        {
            InitializeComponent();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            LogIn logInPage = BurgerMenu.findOpenedForm("LogIn") as LogIn;
            logInPage.tbEmail.Text = "";
            logInPage.tbPassword.Text = "";
            logInPage.Show();
            Session.CurrentUser = null;
            Session.isLoggedIn = false;
            List<Form> formsToClose = Application.OpenForms.Cast<Form>().ToList();
            foreach (Form formToClose in formsToClose)
            {
                if (formToClose.Name != "LogIn")
                {
                    formToClose.Close();
                }
            }
        }
    }
}