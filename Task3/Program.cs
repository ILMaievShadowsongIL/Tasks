using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            WePutItInTheCorrectForm(100);
        }
        public static void WePutItInTheCorrectForm(int number)
        {
            string[] WordForms = {"компьютер", "компьютера", "компьютеров" };
            


            if (number % 100 >= 11 && number % 100 <= 14 || number % 10 == 0 || number % 10 >= 5)

            {
                Console.WriteLine($"{number} " + $"{WordForms[2]}");
            }
            else if (number % 10 == 1)
            {
                Console.WriteLine($"{number} " + $"{WordForms[0]}");
               
            }
            else
            {
                Console.WriteLine($"{number} " + $"{WordForms[1]}");
            }

        }
    }
}
