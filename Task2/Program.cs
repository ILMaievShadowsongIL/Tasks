using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float enter = EnteringTheData();
            float roundingUp = RoundingTheNumber(enter);
            Console.WriteLine($"Число, которое мы округлили: {roundingUp}");
        }
        public static float EnteringTheData()
        {
            Console.Write("Пожалуйста, введите число: ");
            return Convert.ToSingle(Console.ReadLine());
        }
        public static int RoundingTheNumber(float number)

        {
            return Convert.ToInt32(Math.Round(number, 5));
        }
    }
}
