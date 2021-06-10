using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenate
            string word = "Concatenate";
            word += " 3";
            word += " strings.\n";
            Console.WriteLine(word);


            //Convert String to upper case
            string upperword = word.ToUpper();
            Console.WriteLine(upperword);


            //Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            StringBuilder create = new StringBuilder();
            create.AppendLine("Example ");
            create.AppendLine("use");
            create.AppendLine("of a ").AppendLine("stringbuilder");
            Console.Write(create);

            Console.ReadLine();
        }
    }
}
