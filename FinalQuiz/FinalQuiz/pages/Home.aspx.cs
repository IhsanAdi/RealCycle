using FinalQuiz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalQuiz.pages
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            guestContent.Visible = memberContent.Visible = adminContent.Visible = false;

            if (Session["email"] == null || Session["role"] == null) guestContent.Visible = true;
            else if (Session["email"] != null || Session["role"] != null)
            {
                var user = UserRepository.searchUser(Session["email"].ToString());
                if (Session["role"].ToString() == "Admin")
                {
                    adminContent.Visible = true;
                }
                else
                {
                    memberContent.Visible = true;

                }
            }

            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            viewData();
        }

        public void viewData()
        {
            topCatalog.DataSource = ProductRepository.get().Take(3);
            topCatalog.DataBind();

            topCatalogMember.DataSource = ProductRepository.get().Take(3);
            topCatalogMember.DataBind();

            topCatalogAdmin.DataSource = ProductRepository.get().Take(3);
            topCatalogAdmin.DataBind();
        }
    }
}