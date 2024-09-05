using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CustomConvert
    {
        public static void Convert(string input,out int result)
        {
            result = System.Convert.ToInt32(input);
            
        }
        public static void Convert(string input, out double result)
        {
            result = System.Convert.ToDouble(input);

        }
        public static void Convert(string input, out bool result)
        {
            result = System.Convert.ToBoolean(input);
        }
    }
}
