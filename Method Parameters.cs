using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysInDotNet
{
    class Student
    {
        public string Name { get; set; }
        public bool IsEnrolled { get; set; }
    }
    internal class Method_Parameters
    { 
        public static void  EnrollStudent(in Student student)
        {
            //with in assigning a new object would throw an eror
            //student = new Student();//not allowed because student is passed with parameters
            student.Name = "bhawana";
            Console.WriteLine(student.Name);


        }
        public static void OptionalorDefault(int age , string name , double salary=3000)
        {
            Console.WriteLine($"Salary is {salary}");

        }
        public static void NamedParameters(int x, bool isBool, char c)
        {
            Console.WriteLine(x);
        }
        public static void OutPrameter(out int phone)
        {
            phone = 0;//has to be initailzed within function as it is an out parameter
            //phone = phone + 1;//not allowed
            Console.WriteLine(phone);
        }
        public static void Display(int sal)
        {
            Console.WriteLine(sal);
        }
        public static void Show(ref int age)
        {
            Console.WriteLine(age);
        }
        public static int Add(params int [] x)
        {
            int sum = 0;
            //sum = a + b + c;
            foreach (var item in x)
            {
                sum = sum + item;
            }
            return sum;
        }
        static void Main()
        {
            Console.WriteLine($"Sum of parameters is :{Add(5,6,8)}");
            Display(5);
            int age = 5;
            

            //Show(ref 5);//not allowed because ref parameter has to be initialized before we use it
            Show(ref age);
            //calling out parameter
            int result;
            OutPrameter(out result);

            //calling out Namedparameters
            NamedParameters(c: 'F',  x: 23, isBool: true);//order of parameter list is changed because we used the name of the variables  and assigned value

            //calling optional or default parameter
            Console.WriteLine("Salary : when we are using default salary");
            OptionalorDefault(23, "bhawana");//it is optional to pass the default parameter
            Console.WriteLine("Salary :when not using the defaultvalue");
            OptionalorDefault(55, "jhon", 5666);//passing the optional parameter not using the default value

            //calling method with in parameter
            var student = new Student();
            EnrollStudent(in student);
            Console.Read();

        }
    }
}
