using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int[] numbers = { 1, 2, 3, 4, 5, 6};
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
            


        }
    }
}
