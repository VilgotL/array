using System;

namespace uppgift4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] spelplan = new char[,] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };
            spelplan[0, 1] = 'x';
            spelplan[1, 1] = 'o';
            spelplan[0, 2] = 'x';
            for (int i = 0; i < spelplan.GetLength(0); i++)
            {
                for (int j = 0; j < spelplan.GetLength(1); j++)
                {
                    Console.Write(spelplan[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
