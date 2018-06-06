using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbisoftTechnicalAssesment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,c = 0;
            bool j = false;
            var sb = new StringBuilder(); //Original Array
            var rsb = new StringBuilder(); //Reversed Array
            var ssb = new StringBuilder(); //Second number array
            var bsb = new StringBuilder(); //Bonus for sixth number
            int[] list = { 6, 5, 32, 0, 26, 16, 23, 12, 77, 58, 4, 67 };
            int[] revList = new int[list.Length];
            for (i = 0; i <= list.Length - 1; i++)
            {                
                sb.Append(list[i]);
                revList[(list.Length-1) - i] = list[i];
                if (i < list.Length - 1) {
                    sb.Append(",");
                }
                if (j == true) {
                    ssb.Append(list[i]);
                    ssb.Append(",");
                    j = false;
                }else
                {
                    j = true;
                }c++;
                if (c == 6) {
                    bsb.Append(((list[i] * list[i]) + 1));
                    bsb.Append(",");
                    c = 0;
                }
            }
            
            foreach (int value in revList)
            {
                rsb.Append(value);
                rsb.Append(",");
            }

            Console.WriteLine("Original Array: {0}", sb);
            Console.WriteLine("Reverse Array: {0}", rsb.Remove((rsb.Length - 1), 1));
            Console.WriteLine("Every Second Number: {0}", ssb.Remove((ssb.Length - 1), 1));
            Console.WriteLine("Bonus for (Sixth Number*itself) + 1: {0}", bsb.Remove((bsb.Length - 1), 1));
            Console.ReadLine();

        }
    }
}
