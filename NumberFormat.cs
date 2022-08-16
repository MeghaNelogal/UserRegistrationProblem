using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class NumberFormat
    {
        
       public static string REGEX_MobileNo = "^[0-9]{1,3}[ ][6789][0-9]{9}$"; // 91 9008077654

         public bool ValidateMobileNo(string MobileNo)
         {
                return Regex.IsMatch(MobileNo, REGEX_MobileNo);
         }
        
    }
}

