using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysInDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array is an abstract class
            string[] arr = {"Apple","Orange"};
            Console.WriteLine("Enter integer element in the array");
            // Array arr = Array.CreateInstance(typeof(int), 4);
            for (int i = 0; i < arr.Length; i++)//adding the elements into array using for loop
            {
                arr[i] = (Console.ReadLine());
            }
            //reading the elements from the array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i++]);

            }
            Console.WriteLine();
            Console.ReadLine();




            Console.WriteLine($"Length of the array is :{arr.Length}");
            int [] res =new int[arr.Length];//res here is an empty array and size is same as array
            arr.CopyTo(res, 0);
            
            Console.WriteLine("After copying elements of arr");
            foreach(var item in res)
                Console.WriteLine(item);
            //arr.CopyTo(new int[arr.Length], 0);
            var output = (Array)arr.Clone();//casted it to array

            foreach(var item in output)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Value at index is" + arr.GetValue(2));

        }
    }
}
