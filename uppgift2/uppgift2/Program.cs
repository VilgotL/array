using System;

namespace uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperatur = { 4.5, 3.2, 6.7, 6.1, 2.1, 1.6, 2.9 };
            double summa = 0;
            for (int i = 0; i < temperatur.Length; i++)
            {
                summa += temperatur[i];
            }
            double medelvärde = Math.Round((summa / temperatur.Length), 2);
            Console.WriteLine("Medelvärdet är " + medelvärde);
        }
    }
}
