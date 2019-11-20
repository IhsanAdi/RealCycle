using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalQuiz.Controller
{
    public class UserController
    {
        public static bool isAlphaNum(String str)
        {
            if (string.IsNullOrEmpty(str)) return false;
            for(int i = 0; i < str.Length; i++)
            {
                if(!(char.IsLetter(str[i])) && (!(char.IsNumber(str[i])))){
                    return false;
                }
            }
            return true;
        }

        public static bool isNum(String str)
        {
            if (string.IsNullOrEmpty(str)) return false;
            for (int i = 0; i < str.Length; i++)
            {
                if ((!(char.IsNumber(str[i])))){
                    return false;
                }
            }
            return true;
        }

        public static bool valName(String name)
        {
            if (String.IsNullOrEmpty(name)) return false;
            return true;
        }

        public static bool valEmail(string email)
        {
            if (String.IsNullOrEmpty(email)) return false;
            return true;
        }

        public static bool valPass(string password)
        {
            if (String.IsNullOrEmpty(password)) return false;
            else if (!isAlphaNum(password)) return false;
            else if (password.Length < 8) return false;
            return true;
        }

        public static bool valConfPass(string password, string confPass)
        {
            if (String.IsNullOrEmpty(confPass)) return false;
            else if (!password.Equals(confPass)) return false;
            return true;
        }

        public static bool valGender(string gender)
        {
            if (String.IsNullOrEmpty(gender)) return false;
            return true;
        }

        public static bool valBDO(DateTime BDO)
        {
            if (BDO == DateTime.MinValue.Date) return false;
            else if ((DateTime.Now.Year - BDO.Year) < 17) return false;
            return true;
        }

        public static bool valPhone(string numb)
        {
            if (String.IsNullOrEmpty(numb)) return false;
            else if (!isNum(numb)) return false;
            else if (numb.Length < 10 || numb.Length > 12) return false;
            return true;
        }

        public static bool valAddress(string address)
        {
            if (String.IsNullOrEmpty(address)) return false;
            else if (!address.EndsWith(" Street")) return false;
            return true;
        }


    }
}