using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the Percentage of student :");
                int per = Convert.ToInt32(Console.ReadLine());
                if (per > 70)
                {
                    Console.WriteLine("Your Grade is A");
                }
                else if (per > 60)
                {
                    Console.WriteLine(" Your Grade is B");
                }
                else if (per > 50)
                {
                    Console.WriteLine(" Your Grade is C");
                }
                else if (per > 40)
                {
                    Console.WriteLine("Your Grade is D");
                }
                else if (per < 40)
                {
                    Console.WriteLine("Fale");
                }
                else
                {
                    Console.WriteLine("Not Valid");
                }
                Console.ReadKey();
            }
    }
}
