using FinalQuiz.Model;
using FinalQuiz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalQuiz.View
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            guestMenu.Visible = adminMenu.Visible = memberMenu.Visible = false;

            if (Session["email"] == null || Session["role"] == null)
            {
                guestMenu.Visible = true; guestGreetings.Text = "Welcome, Guest. Time: " + DateTime.Now.ToString("hh:mm:ss tt");
            }else if (Session["email"] != null || Session["role"] != null)
            {
                var user = UserRepository.searchUser(Session["email"].ToString());
                if (Session["role"].ToString() == "Admin")
                {
                    adminMenu.Visible = true;
                    adminGreetings.Text = "Welcome, " + user.Name + ". Time: " + DateTime.Now.ToString("hh:mm:ss tt");
                }
                else
                {
                    memberMenu.Visible = true;
                    memberGreetings.Text = "Welcome, " + user.Name + ". Time: " + DateTime.Now.ToString("hh:mm:ss tt");
                }
            }

            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }
    }
}