using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
			int i = 1;
			do
			{
		     
				Console.WriteLine(i);
				i++;
				if (i % 2 != 0)
				break;

			} while (i <= 50);
			Console.ReadKey();
		}
    }
}
