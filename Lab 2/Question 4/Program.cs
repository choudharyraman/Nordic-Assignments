using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter the age in string : ");
            string str_age = Console.ReadLine();
            Type ty = str_age.GetType();
            Console.WriteLine("Data type of Age is " + ty);
            bool int_age = int.TryParse(str_age, out age);
            Console.WriteLine("Your int value of age is " + age);
            Type ty1 = age.GetType();
            Console.WriteLine("After conver Data type of Age is " + ty1);
            Console.ReadKey();
        }
    }
}
