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
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null || Session["role"] == null)
            {
                Response.Redirect("~/pages/Login.aspx");
            }

            if (Session["role"].ToString().Equals("Admin"))
            {
                updateBtn.Visible = true;
            }

            if (Session["role"].ToString().Equals("Member"))
            {
                cart.Visible = true;
                amount.Visible = true;
            }

            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("~/pages/Products.aspx");
            }

            int id = int.Parse(Request.QueryString["id"]);
            var product = ProductRepository.findProduct(id);
            if (product == null)
            {
                Response.Redirect("~/pages/Products.aspx");
            }
            if (!IsPostBack) setData(product);
            viewData();
        }

        protected void setData(Product product)
        {
            ProductID.Value = product.ProductId.ToString();
        }

        public void viewData()
        {
            var id = int.Parse(ProductID.Value);
            detailGridView.DataSource = ProductRepository.getProduct(id);
            detailGridView.DataBind();
        }

        protected static bool IsNum(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsNumber(str[i]) == false)
                    return false;
            }

            return true;
        }

        protected void cart_Click(object sender, EventArgs e)
        {
            var id = int.Parse(ProductID.Value);
            Product product = new Product();
            product = ProductRepository.findProduct(id);
            HttpCookie cartCookie = new HttpCookie("ProductDetail");

            if (string.IsNullOrEmpty(amount.Text))
            {
                errorLbl.Text = "Cannot be Empty";
                errorLbl.Visible = true;
            }
            else if (IsNum(amount.Text) == false)
            {
                errorLbl.Text = "Must be Numeric";
                errorLbl.Visible = true;
            }
            else if (int.Parse(amount.Text) <= 0)
            {
                errorLbl.Text = "Cannot be <= 0";
                errorLbl.Visible = true;
            }
            else if (int.Parse(amount.Text) > (int)product.Stock)
            {
                errorLbl.Text = "Not Enough Stock";
                errorLbl.Visible = true;
            }
            else
            {
                int total = (int)product.Stock * int.Parse(amount.Text);

                cartCookie.Values.Add("ProductName", product.ProductName.ToString());
                cartCookie.Values.Add("ProductPicture", product.Picture.ToString());
                cartCookie.Values.Add("ProductQuantity", amount.Text.ToString());
                cartCookie.Values.Add("ProductPrice", total.ToString());
                cartCookie.Expires.AddYears(1);
                errorLbl.Text = "Success";
                errorLbl.Visible = true;
            }

        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            var id = int.Parse(ProductID.Value);
            Product product = new Product();
            product = ProductRepository.findProduct(id);

            Response.Redirect("~/pages/UpdateProduct.aspx");
        }
    }
}