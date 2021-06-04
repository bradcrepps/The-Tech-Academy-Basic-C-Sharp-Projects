using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Application_pg185
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("What number would you like to perfrom calculations on? ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(input + " + 2 = " + Operations.addTwo(input));
            Console.WriteLine(input + " - 2 = " + Operations.subTwo(input));
            Console.WriteLine(input + " / 2 = " + Operations.divTwo(input));

            Console.Read();






        }
    }
}
