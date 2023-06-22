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
        public static string USER_NAME = "^[A-Z]{1}[a-z]{3,}";

        public string FirstName(string name)
        {
            if(Regex.IsMatch(name,USER_NAME))
                return "Valid";
                return "Invalid";
        }
    }
}
