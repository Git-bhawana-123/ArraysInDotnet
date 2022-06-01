using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysInDotNet
{
    internal class StringClass
    {
        class  Employee
        {
            public void Show()
            {

            }
        }
        static void Main()
        {
          
            string str = "A good beginning makes a good ending";
          var SplitString = str.Split(' ');//splitting the string str wherver there is a space
            str.Split(' ');
            
          foreach(var item in SplitString)
            {
                Console.WriteLine(item + ",");
            }
          Console.WriteLine($"String in lowercase:{str.ToLower()}");
            Console.WriteLine($"String in lowercase:{str.ToUpper()}");
            var charArr=str.ToCharArray();
            Console.WriteLine("String to char array:");
            foreach(var item in charArr)
            {
                Console.WriteLine(item);

            }

            StringBuilder sb=new StringBuilder();

            
            Console.Read();
           


        }
       
    }
}
