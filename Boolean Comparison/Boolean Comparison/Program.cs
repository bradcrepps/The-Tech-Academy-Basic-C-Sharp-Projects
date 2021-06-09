using System;

namespace Boolean_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {

            //Two different programs showing usage of while and do while with boolean comparison
            
            //while
            Console.WriteLine("1, 2, 3, 4, ?, 6");
            Console.WriteLine("What is the missing number?: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            bool number = input1 == 5;

            while (!number)
            {
                switch (input1)
                {
                    case 5:
                        Console.WriteLine("Correct! Press enter for the next problem.");
                        number = true;
                        break;
                    default:
                        Console.WriteLine("Try again.");
                        input1 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
                Console.ReadLine();
            }

            //do while 
            Console.WriteLine("What is 1 + 0?");
            int input2 = Convert.ToInt32(Console.ReadLine());
            bool number2 = input2 == 1;

            do
            {
                switch (input2)
                {
                    case 0:
                        Console.WriteLine("Try again");
                        input2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("Correct!");
                        number2 = true;
                        break;
                    default:
                        Console.WriteLine("Try again, hint: Write it out");
                        input2 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!number2);
            Console.ReadLine();
        }
    }
}
