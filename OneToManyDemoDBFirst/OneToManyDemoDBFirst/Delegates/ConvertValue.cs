using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyDemoDBFirst.Delegates
{
    public delegate T TypeConvertDelegate<T>(string value);
    public class ConvertValue
    {
        public static int ConvertInt(string value)
        {
            return Convert.ToInt32(value);
        }
        public static DateTime ConvertDateTime(string value)
        {
            return Convert.ToDateTime(value);
        }
    }
}
