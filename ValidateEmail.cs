using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class ValidateEmail
    {
        public static string REGEX_EMail = "^(abc).?[a-z]{3,}[@](bl).?(co).?[a-z]{2,}$"; //abc.xyz@bl.co.in

        public bool ValidateEMail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMail);
        }
    }
}

