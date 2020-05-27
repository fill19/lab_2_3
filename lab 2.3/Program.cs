using System;

namespace lab_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;

            int[] a = new int[n];

            Random r = new Random();

            for (int i = 0; i < a.Length; i++)
                a[i] = r.Next(-100, 100);

            Console.WriteLine();

            for (int i = 0; i < n; ++i)
                Console.Write("\t" + a[i]);


            Console.WriteLine();


            int p = 1;

            Console.WriteLine("Добуток додатних елементів:");
            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] > 0)
                {
                    p *= a[i];
                }
            }
            Console.WriteLine(p);
        }
    }
}
 