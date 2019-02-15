using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine()); // reading the input (it will also be the height of the triangle)
            string[,] d = new string[k, k]; // 2d string array 
            for (int i = 0; i < k; ++i)
                for (int j = 0; j <= i; ++j)
                    d[i, j] = "[*]"; // Writing in i, j 

            for (int i = 0; i < k; ++i, Console.WriteLine()) // similarly to C++
                for (int j = 0; j <= i; ++j)
                    Console.Write(d[i, j]); // derive the data

            Console.ReadKey();
        }
    }
}
