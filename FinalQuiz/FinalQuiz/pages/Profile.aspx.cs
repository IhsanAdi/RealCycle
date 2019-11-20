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
    public partial class Profile : System.Web.UI.Page
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

        protected static bool IsAlphaNum(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            for (int i = 0; i < str.Length; i++)
            {
                if (!(char.IsLetter(str[i])) && (!(char.IsNumber(str[i]))))
                    return false;
            }

            return true;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string email = (string) HttpContext.Current.Session["email"];
            string oldPassword = oldPass.Text;
            string newPassword = newPass.Text;
            string confPassword = confPass.Text;

            User user = UserRepository.searchUser(email);

            if (string.IsNullOrEmpty(oldPassword) && string.IsNullOrEmpty(newPassword) && string.IsNullOrEmpty(confPassword))
            {
                msgLabel.Text = "Tidak boleh ada yang kosong";
                msgLabel.Visible = true;
                return;
            }


            if(oldPassword != user.Password)
            {
                msgLabel.Text = "Password lama salah";
                msgLabel.Visible = true;
                return;
            }

            if(!IsAlphaNum(newPassword))
            {
                msgLabel.Text = "Password alphanumeric";
                msgLabel.Visible = true;
                return;
            }

            if(newPassword.Length <= 8)
            {
                msgLabel.Text = "Password minimal 8";
                msgLabel.Visible = true;
                return;
            }

            if(newPassword != confPassword)
            {
                msgLabel.Text = "Password tidak sama dengan konfirmasi";
                msgLabel.Visible = true;
                return;
            }

            UserRepository.updatePassword(email, oldPassword, newPassword, confPassword);

            msgLabel.Text = "Sukses";
            msgLabel.Visible = true;
            Response.Redirect("~/pages/Profile.aspx");
        }
    }
}