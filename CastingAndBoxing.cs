using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysInDotNet
{
    internal class CastingAndBoxing
    {
        static void Main()
        {
            //example of implicit casting value types
            int age = 22;
            double d;
            d = age;//on the left hand side of equal to we have double , right hand side we have integer, but implicit casting has been achieved
            Console.WriteLine(d);

            //example of explicit casting
            double price = 10.8;
            int x;
            x=(int)price;
            Console.WriteLine(x);

            //explicit casting with refernce type

            //Person person = new Emp();
            var arr =new int[] { 1, 2, 3, 4, 5, 6, 7 };
            object newArr = (Array)arr.Clone();//explicit casting with refernce type
            //boxing
            int numbr = 100;//value type
            object num;//refernce type
            num = numbr;//boxing (value type is pointing to refernce type)it happen implicitly

            //unboxing
            double amount;
            object rate = 405.50;
            amount =(double)rate;//unboxing (converted refernce type to value type)explicilty

            Console.WriteLine(num);//will display 100
            Console.Read();

        }
    }
}
