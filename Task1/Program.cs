using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "Москва", " Санкт - Петербург", " Воронеж" };
            ChangingTheLine(cities);
        }
        public static void ChangingTheLine(string[] array)
        {
            string separatedNames = string.Join(",", array);
            Console.Write($"{separatedNames}. ");
        }
    }
}
