using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysInDotNet
{
    internal class StringBuilderClass
    {
        static void Main()
        {
            string str = "Hello all";
            string str1 = "Today is Tuesday";

            StringBuilder sb = new StringBuilder("This is a string");
            sb.AppendLine("this is another string");
            Console.WriteLine(sb.Length);
            //sb.Length = 10;
            Console.WriteLine(sb);
            sb.AppendFormat("{0} and \n {1}",str,str1);
            Console.WriteLine(sb);
           //to do list:
            //sb.CopyTo();
            //sb.Remove();
            //sb.Replace();
            //sb.Clear();
        }
    }
}
