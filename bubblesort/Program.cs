using System;

namespace bubbleSrt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 7, 10, 12, 9, 1, 5 };
            int t;
            Console.WriteLine("Sayı dizisi:");
            foreach (int item in a)
            Console.Write(item + " ");

                for (int i = 0; i <= a.Length-2 ; i++)
                {
                    for (int j = 0; j <= a.Length-2 ; j++)
                    {
                        if (a[j] > a[j + 1])
                        {
                            t = a[j + 1];
                            a[j + 1] = a[j];
                            a[j] = t;

                        }
                    }
                }
                Console.WriteLine("\n" + "sıralı:");
                foreach (var item in a)
                {
                    Console.Write(item + " ");
                }
        }
    }
}
