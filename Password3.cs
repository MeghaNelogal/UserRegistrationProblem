using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class Password3
    {
        public static string REGEX_Password3 = "^[A-Z]{1}[A-Z a-z]{7,}[0-9]{1,}$"; //Meghanel7

        public bool ValidatePassword3(string password)
        {
            return Regex.IsMatch(password, REGEX_Password3);
        }
    }
}
