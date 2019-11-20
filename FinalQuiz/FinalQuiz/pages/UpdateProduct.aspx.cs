using FinalQuiz.Controller;
using FinalQuiz.Model;
using FinalQuiz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalQuiz.pages
{
    public partial class UpdateProduct : System.Web.UI.Page
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
        }

        protected void updateProductBtn_Click(object sender, EventArgs e)
        {
            Regex numeric = new Regex("^[0-9]*$");

            Entities db = new Entities();

            string productName = productNameTextBox.Text;
            string category = categoryTextBox.Text;
            int price = int.Parse(priceTextBox.Text);
            int stock = int.Parse(stockTextBox.Text);
            string description = descriptionTextBox.Text;

            if (ProductController.valName(productName) == false)
            {
                errorName.Visible = true;
            }

            if (ProductController.valCategory(category) == false)
            {
                errorCategoryLbl.Visible = true;
                return;
            }

            if (ProductController.valNumber(price) == false)
            {
                errorPriceLbl.Visible = true;
                return;
            }

            if (ProductController.valNumber(stock) == false)
            {
                errorStockLbl.Visible = true;
                return;
            }

            int words = 0;
            foreach (char c in descriptionTextBox.Text.ToArray())
            {
                if (c == ' ')
                {
                    words++;
                }
            }
            if (words != 6)
            {
                errorDescriptionLbl.Visible = true;
                return;
            }

            String strname = imageFileUpload.FileName.ToString(); ;

            if (imageFileUpload.HasFile)
            {
                imageFileUpload.PostedFile.SaveAs(Server.MapPath("~/upload/") + strname);
            }

            ProductRepository.updateProduct(productName, category, price, stock, strname, description);
            Response.Redirect("~/pages/Products.aspx");
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/pages/Products.aspx");
        }
    }
}