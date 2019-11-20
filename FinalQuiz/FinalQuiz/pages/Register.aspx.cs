using FinalQuiz.Controller;
using FinalQuiz.Factory;
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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static bool isEmailExists(string email)
        {
            return UserRepository.find(email);
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            int val = 0;
            String name = nameTextBox.Text;
            String email = emailTextBox.Text;
            String password = passwordTextBox.Text;
            String confPass = confirmPasswordTextBox.Text;
            String gender = Gender.SelectedValue;
            DateTime dob = DateTime.Parse(DOBTextBox.Text);
            String phoneNumber = phoneTextBox.Text;
            String address = addressTextBox.Text;

            Regex alphanumeric = new Regex("^[a-zA-Z0-9]*$");
            Regex numeric = new Regex("^[0-9]*$");

            if (UserController.valName(name) == false)
            {
                erorName.Visible = true;
            }
            else
            {
                val++;
            }

            if (UserController.valEmail(email) == false)
            {
                errorEmailLbl.Visible = true;
            }
            else
            {
                val++;
            }

            if (UserController.valPass(password))
            {
                errorPasswordLbl.Visible = true;
            }
            else
            {
                val++;
            }

            if (UserController.valConfPass(password, confPass))
            {
                errorConfirmPassword.Visible = true;
            }
            else
            {
                val++;
            }

            if (UserController.valBDO(dob))
            {
                errorDOBLbl.Visible = true;
            }
            else
            {
                val++;
            }

            if (UserController.valPhone(phoneNumber))
            {
                errorPhoneLbl.Visible = true;
            }
            else
            {
                val++;
            }

            if (UserController.valAddress(address))
            {
                errorAddressLbl.Visible = true;
            }
            else
            {
                val++;
            }

            if (val == 7)
            {
                User user = UserFactory.createUser(name, email, password, gender, dob, phoneNumber, address, "Member");
                UserRepository.register(user);
                Response.Redirect("~/pages/Login.aspx");
            }


        }
    }
}