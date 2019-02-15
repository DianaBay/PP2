using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace L1T1
{
    class Program
    {
        public static bool isPrime(int x) // finding out, whether the number is Prime or not
        {
            if (x < 2)         // a prime number must be greater than 1 (and it is only divisible by 1 and itself)
                return false;
            for (int j = 2; j <= Math.Sqrt(x); ++j) // where Math.Sqrt(x) means taking square root of x usin Math
                if (x % j == 0)
                    return false;
            return true;
        }

        static void Main(string[] args)
        {
            int k;
            k = int.Parse(Console.ReadLine()); // reading line and converting to int
            int[] arr = new int[k]; // opening an array with k length
            int cnt = 0; // cnt-counter that will count amount of prime numbers
            int x; // number
            string[] numbers = Console.ReadLine().Split(); // reading line and spliting
            for (int i = 0; i < k; ++i) // cycle
            {
                x = int.Parse(numbers[i]); // converting each number to int
                if (isPrime(x)) // checking whether x prime or not by function
                    arr[cnt++] = x;
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < cnt; ++i)
            {
                Console.Write(arr[i].ToString() + " "); // output answers in a string form
            }

            Console.ReadKey();
        }
    }
}