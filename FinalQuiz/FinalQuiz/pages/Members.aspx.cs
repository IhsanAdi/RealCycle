using FinalQuiz.Model;
using FinalQuiz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalQuiz.pages
{
    public partial class Members : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["email"] != null && Session["email"] == null)
            {
                Session["email"] = Request.Cookies["email"].Value;
            }

            if (Session["email"] == null) Response.Redirect("~/pages/Login.aspx");
            else if (Session["email"] != null)
            {
                User user = UserRepository.searchUser(Session["email"].ToString());
                if (user.Role != "Admin")
                {
                    Response.Redirect("~/pages/Login.aspx");
                }
            }

            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            viewData();
        }

        public void viewData()
        {
            userGridView.DataSource = UserRepository.getMember();
            userGridView.DataBind();
        }

        protected void adminBtn_Click(object sender, EventArgs e)
        {
            UserRepository.setAsAdmin(emailTextBox.Text);
            Response.Redirect("~/pages/Members.aspx");
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            UserRepository.deleteUser(emailTextBox.Text);
            Response.Redirect("~/pages/Members.aspx");

        }
    }
}