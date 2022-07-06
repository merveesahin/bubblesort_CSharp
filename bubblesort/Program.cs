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

                for (int i = 0; i < a.Length-1; i++)
                {
                    for (int j = 0; j < a.Length-i-1 ; j++) //önceye dönmesin diye -i ve boundof hatası almamak için -1
                    {
                        if (a[j] > a[j + 1])
                        {
                            t = a[j + 1];
                            a[j + 1] = a[j];
                            a[j] = t;

                        } //scop alanı={} //pointer referans vermek için kullanılır..

                    }
                }
                Console.WriteLine("\n" + "sıralı:");
                for (int b = 0; b < a.Length - 1; b++)
                {
                    Console.Write(a[b] + " ");
                }
        }
    }
}
