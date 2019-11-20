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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie user = Request.Cookies["userInfo"];

            if (user != null)
            {
                if (user.Expires > DateTime.Now)
                {
                    emailTextBox.Text = user.Values["userEmail"].ToString();
                }
                else
                {
                    user.Expires = DateTime.Now;
                }
            }

            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            var loginInfo = new Dictionary<string, string>();
            loginInfo.Add("email", emailTextBox.Text);
            loginInfo.Add("password", passwordTextBox.Text);

            User user = UserRepository.find(loginInfo);

            if (user != null)
            {
                HttpCookie cookie = new HttpCookie("userInfo");
                cookie.Values.Add("userId", user.UserId.ToString());
                cookie.Values.Add("userName", user.Name);
                cookie.Values.Add("userEmail", user.Email);
                cookie.Values.Add("roleId", user.Role.ToString());

                if (rememberCheckBox.Checked)
                {
                    cookie.Expires = DateTime.Now.AddHours(1);
                }

                if (user == null)
                {
                    errorLoginLbl2.Visible = true;
                }

                if (emailTextBox.Text == null && passwordTextBox.Text == null)
                {
                    errorEmailLbl.Visible = true;
                    errorPasswordLbl.Visible = true;
                    return;
                }

                Session["email"] = emailTextBox.Text;
                Session["role"] = user.Role;

                Response.Cookies.Add(cookie);


                Response.Redirect("~/pages/Home.aspx");
            
            }
            else
            {
                errorLoginLbl2.Visible = true;
            }
        }
    }
}