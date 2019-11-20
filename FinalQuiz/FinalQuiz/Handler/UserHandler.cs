using FinalQuiz.Factory;
using FinalQuiz.Model;
using FinalQuiz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalQuiz.Handler
{
    public class UserHandler
    {
        public static List<User> get()
        {
            return UserRepository.get();
        }

        public static User searchUser(String user_email)
        {
            return UserRepository.searchUser(user_email);
        }

        public static List<User> all()
        {
            return UserRepository.all().ToList();
        }
        public static bool registerUser(String user_name, String user_email, String user_password, String user_confirm, String user_gender, DateTime user_dob, String user_phoneNumber, String user_address, String user_role)
        {
            User user = UserRepository.searchUser(user_email);
            if (user != null)
            {
                return false;
            } else
            {
                User registerUser = UserFactory.createUser(user_name, user_email, user_password, user_gender, user_dob, user_phoneNumber, user_address, user_role);
                UserRepository.register(registerUser);
                return true;
            }
        }
        public static bool loginUser(string email, string password, bool rememberCheckBox)
        {
            var data = new Dictionary<string, string>();
            data.Add("email", email);
            data.Add("password", password);

            User user = UserRepository.find(data);

            if (user != null)
            {
                HttpContext content = HttpContext.Current;
                content.Session["Role"] = user.Role.ToString();
                content.Session["Name"] = user.Name.ToString();
                content.Session["Email"] = user.Email.ToString();
                content.Session["Password"] = user.Password.ToString();
                if (rememberCheckBox)
                {
                    content.Response.Cookies["Role"].Value = content.Session["Email"].ToString();
                    content.Response.Cookies["Name"].Value = content.Session["Password"].ToString();
                    content.Response.Cookies["Email"].Expires = DateTime.Now.AddHours(1);
                    content.Response.Cookies["Password"].Expires = DateTime.Now.AddHours(1);
                }
                else
                {
                    content.Response.Cookies["Email"].Expires = DateTime.Now.AddHours(-1);
                    content.Response.Cookies["Password"].Expires = DateTime.Now.AddHours(-1);
                }
                return true;
            }
            else
            {
                return false;
            }
        }    
        public static bool deleteUser(string email)
        {
            UserRepository.deleteUser(email);
            return true;
        }
        public static User checkedPassword(String email, String password)
        {
            var data = new Dictionary<string, string>();
            data.Add("email", email);
            data.Add("password", password);

            User user = UserRepository.find(data);
            return user;
        }
        public static bool updatePassword(String email, String oldPassword, String newPassword, String confPassword)
        {
            UserRepository.updatePassword(email, oldPassword, newPassword, confPassword);
            return true;
        }
    }
}