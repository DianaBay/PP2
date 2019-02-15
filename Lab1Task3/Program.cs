using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;  // amount of input numbers
            k = int.Parse(Console.ReadLine()); // reading line and converting it to int 
            int[] arr = new int[k];  // new array with length k
            string[] numbers = Console.ReadLine().Split(); // reading and spliting
            for (int i = 0; i < numbers.Length; ++i) // cycle for numbers
            {
                for (int j = 0; j < 2; ++j)
                {
                    Console.Write(numbers[i] + " "); // duplicate number
                }
            }
            Console.ReadKey();
        }
    }
}
