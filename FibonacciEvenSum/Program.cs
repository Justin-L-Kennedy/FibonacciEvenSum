using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbr1 = 0;
            int nbr2 = 1;
            int evenSum = 0;
            for (int i = 1; i < 40; i++)
            {
                int sequence = nbr1 + nbr2;
                if (sequence < 4000000) //sequence value under 4 million
                {
                    Console.WriteLine(sequence);
                    nbr1 = nbr2;
                    nbr2 = sequence;
                    if (sequence % 2 == 0) //find only even numbers in sequence
                    {
                        evenSum += sequence;
                    }
                }
            }
            Console.WriteLine(evenSum);
        }
    }
}
