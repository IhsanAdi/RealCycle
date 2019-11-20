using FinalQuiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalQuiz.Factory
{
    public class UserFactory
    {
        public static User createUser(String name, String email, String password, String gender, DateTime dob, String phoneNumber, String address, String role)
        {
            User user = new User();
            user.Name = name;
            user.Email = email;
            user.Password = password;
            user.Gender = gender;
            user.DOB = dob;
            user.PhoneNumber = phoneNumber;
            user.Address = address;
            user.Role = role;

            return user;
        }
    }
}