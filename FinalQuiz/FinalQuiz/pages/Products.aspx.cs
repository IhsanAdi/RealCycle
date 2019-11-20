using FinalQuiz.Model;
using FinalQuiz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalQuiz.pages
{
    public partial class ViewProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            adminContent.Visible = false;

            if (Session["email"] == null || Session["role"] == null) adminContent.Visible = false;
            else if (Session["email"] != null || Session["role"] != null)
            {
                if (Session["role"].ToString() == "Admin")
                {
                    adminContent.Visible = true;
                }
                else
                {
                    adminContent.Visible = false;
                }
            }

            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            viewData();
        }

        public void viewData()
        {
            productGridView.DataSource = ProductRepository.get().Take(10);
            productGridView.DataBind();
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            ProductRepository.deleteProduct(productName.Text);
            Response.Redirect("~/pages/Products.aspx");
        }

        protected void filterDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(filterDropdown.SelectedValue == "All")
            {
                productGridView.DataSource = ProductRepository.get().Take(10);
                productGridView.DataBind();
            }else if(filterDropdown.SelectedValue == "Bike")
            {
                productGridView.DataSource = ProductRepository.getBike().Take(10);
                productGridView.DataBind();
            }else if(filterDropdown.SelectedValue == "Clothing")
            {
                productGridView.DataSource = ProductRepository.getClothing().Take(10);
                productGridView.DataBind();
            }else
            {
                productGridView.DataSource = ProductRepository.getAccessories().Take(10);
                productGridView.DataBind();
            }
        }

        protected void addBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/pages/AddProduct.aspx");
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/pages/UpdateProduct.aspx");
        }
    }
}