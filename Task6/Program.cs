using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {

        static void Main(string[] args)
        {
            OutputOfTheMultiplicationTable(7);

        }
        public static void OutputOfTheMultiplicationTable(int number)
        {
            var table = new int[10, 10];
            for (int i = 1; i <= number; ++i)
            {
                for (int j = 1; j <= number; ++j)
                {
                    table[i, j] = i * j;
                }
            }
            for (int i = 1; i <= number; ++i)
            {
                for (int j = 1; j <= number; ++j)
                {
                    Console.Write(" {0, 3}", table[i, j]);
                }
                Console.WriteLine();
            }

        }

       

    }

    }









