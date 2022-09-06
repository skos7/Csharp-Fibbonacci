using System;

namespace Fibonacci
{
    class Program
    {

        static void fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            int next = a + b;

            Console.WriteLine(a + "\n" + b);

            for(int i = 3; i < n; i++)
            {
                Console.WriteLine(next);
                a = b;
                b = next;
                next = a + b;
            }
        }

        static void Main(string[] args)
        {
            
            Console.Write("Insert Fibonacci number: ");
            int n = Convert.ToInt32(Console.ReadLine());



            fibonacci(n);
        }
    }
}
