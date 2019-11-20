using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalQuiz.Controller
{
    public class ProductController
    {
        public static bool isAlphaNum(String str)
        {
            if (string.IsNullOrEmpty(str)) return false;
            for (int i = 0; i < str.Length; i++)
            {
                if (!(char.IsLetter(str[i])) && (!(char.IsNumber(str[i])))){
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
                if ((!(char.IsNumber(str[i]))))
                {
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

        public static bool valCategory(string category)
        {
            if (String.IsNullOrEmpty(category)) return false;
            if (category != "Bike" && category != "Clothing" && category != "Accessories") return false;
            return true;
        }

        public static bool valNumber(int number)
        {
            if (number <= 0) return false;
            return true;
        }

        public static bool valDesc(string desc)
        {
            if (String.IsNullOrEmpty(desc)) return false;
            else if (desc.Length < 7) return false;
            return true;
        }


    }
}