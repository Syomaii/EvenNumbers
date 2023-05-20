using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start, end, sum = 0;
            Console.Write("Enter starting number: ");
            start = int.Parse(Console.ReadLine());
            Console.Write("Enter ending number: ");
            end = int.Parse(Console.ReadLine());
            Console.Write("\nEven numbers: ");
            int num = start;
            do
            {
                if (num % 2 == 0)
                {
                    Console.Write(" "+num);
                    sum += num;
                }
                num++;
            } while (num <= end);
            Console.WriteLine($"\nSum of all even numbers from {start} to {end} is {sum}");
            Console.ReadLine();
        }
    }
}
