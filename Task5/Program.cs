using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputAnArray();
        }
        public static void OutputAnArray()
        {
            Random rand = new Random();
            int number = 20;
            int[] aNumber = new int[number];
            int[] bNumber = new int[number];
            for (int i = 0; i < number; ++i)
            {
                aNumber[i] = rand.Next(10, 51);
                bNumber[i] = rand.Next(10, 51);
            }
            Array.Sort(aNumber);
            foreach (var i in aNumber) Console.Write(" " + i);            
            Array.Sort(bNumber);
            Console.WriteLine();
            foreach (var i in bNumber) Console.Write(" " + i);
            Console.WriteLine();
            object item;
            int index;
            for (int i = 0; i < number; ++i)
            {
                item = aNumber[i];
                if (i > 0 && item == (object)aNumber[i - 1]) continue;
                index = Array.BinarySearch(bNumber, item);
                if (index >= 0) Console.Write(" " + aNumber[i]);
            }
           
        }
    }
}
        
              

     
           
      

