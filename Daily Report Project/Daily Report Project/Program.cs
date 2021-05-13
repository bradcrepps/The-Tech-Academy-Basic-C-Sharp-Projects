using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report_Project
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Aacademy\nStudent Daily Report");
            Console.ReadLine();


            //Name entry
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            //Course entry
            Console.WriteLine("What course are you on?");
            string courseNumber = Console.ReadLine();

            //Page number of course entry
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            //Does the student need help entry
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            bool input = Convert.ToBoolean(Console.ReadLine());

            //Positive or negative experince entry
            Console.WriteLine("Where there any positive or negative experiences you'd like to share? Please give specifics.");
            string stuExp = Console.ReadLine();

            //Additional feedback entry
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific?");
            string stuFeedback = Console.ReadLine();

            //Hours studied Entry
            Console.WriteLine("How many hours did you study today?");
            int studyTime = Convert.ToInt32(Console.ReadLine());

            //Ending statement
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
