using System;

namespace uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Skriv in ett heltal: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 4; i >= 0; i--)
            {
                Console.Write(a[i] + ", ");
            }
        }
    }
}
