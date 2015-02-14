using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, -2, 3, 0, -4, 5 };
            // Create a query that obtains only positive numbers.
            var posNums = from n in nums
                          where n > 0
                          select n;
            Console.Write("The positive values in nums: ");
            // Execute the query and display the results.
            foreach (int i in posNums) Console.Write(i + " ");
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
