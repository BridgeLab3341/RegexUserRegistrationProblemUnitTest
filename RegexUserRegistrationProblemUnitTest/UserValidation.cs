using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistrationProblemUnitTest
{
    public class UserValidation
    {
        public static string USER_NAME = "^[A-Z]{1}[a-z]{3,}$";
        public static string EMAIL = "^[a-c]{3}[.]{1}[a-z]{3,}[@]{1}[a-z]{2,}[.]{1}[a-z]{2,}[.]{1}[a-z]{2,}$";
        public static string MOBILE_NUMBER = "^[1-9]{2}[ ]{1}[6-9]{1}[0-9]{9}$";
        public static string PASSWORD_RULE1 = "^[0-9]{8}$";
        public static string PASSWORD_RULE2 = "^[A-Z]{1,}[a-z0-9]{7,}$";

        public string FirstName(string name)
        {
            if(Regex.IsMatch(name,USER_NAME))
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }    
        }
        public string LastName(string name)
        {
            if (Regex.IsMatch(name,USER_NAME))
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
        public string Email(string name)
        {
            if (Regex.IsMatch(name, EMAIL))
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
        public string MobileNumber(string number)
        {
            if(Regex.IsMatch(number,MOBILE_NUMBER))
            {
                return "Valid";
            }
            else
            {
                return "InValid";
            }
        }
        public string Password_Rule1(string password)
        {
            if(Regex.IsMatch(password, PASSWORD_RULE1))
            {
                return "Valid";
            }
            else
            {
                return "InValid";
            }
        }
        public string Password_Rule2(string password1)
        {
            if (Regex.IsMatch(password1, PASSWORD_RULE2))
            {
                return "Valid";
            }
            else
            {
                return "InValid";
            }
        }
    }
}
