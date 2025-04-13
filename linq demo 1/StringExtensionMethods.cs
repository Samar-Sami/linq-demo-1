using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_demo_1
{
    public static class StringExtensionMethods
    {
        //roles for extension methods
        //1. must be in static class
        //2. it must be static method
        //3. first parameter must be the type u want to extend
        public static bool IsNumeric( string str)
        {
            if (string.IsNullOrEmpty(str)) 
                return false;

            foreach (char c in str)
                if (!char.IsDigit(c))
                    return false;
            return true;
        }
    }
}
