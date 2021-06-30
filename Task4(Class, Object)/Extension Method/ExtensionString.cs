using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
  static  class ExtensionString
    {
        public static string FirstLetterLower(this string result)
        {
            if (result.Length > 0)
            {
                char[] s = result.ToCharArray();
                s[0] = char.ToLower(s[0]);
                return new string(s);
            }
            return result;
        }
    }
}
