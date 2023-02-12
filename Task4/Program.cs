using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
          bool check = CheckingTheNumber(11);
          Console.WriteLine(check);  
        }
        public static bool CheckingTheNumber(int number)
        {

            if (number > 1)
            {
                for (int i = number - 1; i > 1; i--)
                {
                    if ((number % i) == 0)
                        return false;
                }
                return true;
            }
            return false;
        }
    }


    }
    



