using System;

namespace uppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperatur = {4.5, 3.2, 6.7, 6.1, 2.1, 1.6, 2.9};
            Console.WriteLine("Medianen är " + Median(temperatur));
        }
        public static double Median(double[] a)
        {
            Array.Sort(a);
            if (a.Length % 2 != 0)
            {
                int i = a.Length / 2;
                return a[i];
            }
            else
            {
                int j = a.Length / 2;
                int k = (a.Length / 2) - 1;
                double l = (a[j] + a[k]) / 2;
                return l;
            }
        }
    }
}
