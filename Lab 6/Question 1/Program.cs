using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    class fact
    {
        public void factorial(int n)
        {
            int i, f = 1;
            for (i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.Write("Factorial of " + n + " is: " + f);
        }
        static void Main(string[] args)
        {
            fact factorial = new fact();
            Console.WriteLine("Enter number to get factorial :");
            int n = int.Parse(Console.ReadLine());
            factorial.factorial(n);
            Console.ReadLine();
        }
    }
}
