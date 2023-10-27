using System;
namespace DSA_CrashCourse1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 1;
            int length = 0;

            Console.Write(x + " ");
            Console.Write(y + " ");
            while (length < 7)
            {
                int fib = x + y;
                Console.Write(fib + " ");
                x = y;
                y = fib;
                length++;
            }

            Console.WriteLine("\n");

            int[] fibSeq = new int[11];

            fibSeq[0] = 0;
            fibSeq[1] = 1;

            for (int i = 2; i < fibSeq.Length; i++) 
            {
                fibSeq[i] = fibSeq[i-1] + fibSeq[i - 2];
            }
            
            foreach (int i in fibSeq)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
