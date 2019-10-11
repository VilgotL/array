using System;

namespace uppgift4
{
    class Program
    {
        static void Main(string[] args)
        {

            char[,] spelplan = new char[,] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };
            int antalrundor = 0;
            while (!Vinst(spelplan))
            {
                for (int i = 0; i < spelplan.GetLength(0); i++)
                {
                    for (int j = 0; j < spelplan.GetLength(1); j++)
                    {
                        Console.Write(spelplan[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.Write("Vilken rad?: ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Vilken kolumn?: ");
                int column = int.Parse(Console.ReadLine());
                if (spelplan[(row - 1), (column - 1)] != 'x')
                {
                    if (spelplan[(row - 1), (column - 1)] != 'o')
                    {
                        if (antalrundor % 2 == 0)
                        {
                            spelplan[(row - 1), (column - 1)] = 'x';
                        }
                        else
                        {
                            spelplan[(row - 1), (column - 1)] = 'o';
                        }
                        Console.WriteLine();
                        antalrundor++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Den här platsen är upptagen.");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Den här platsen är upptagen.");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Du vann!");
        }
        public static bool Vinst(char[,] a)
        {
            if (a[0, 0] == 'x' && a[0, 1] == 'x' && a[0, 2] == 'x')
            {
                return true;
            }
            else if (a[1, 0] == 'x' && a[1, 1] == 'x' && a[1, 2] == 'x')
            {
                return true;
            }
            else if (a[2, 0] == 'x' && a[2, 1] == 'x' && a[2, 2] == 'x')
            {
                return true;
            }
            else if (a[0, 0] == 'x' && a[1, 0] == 'x' && a[2, 0] == 'x')
            {
                return true;
            }
            else if (a[0, 1] == 'x' && a[1, 1] == 'x' && a[2, 1] == 'x')
            {
                return true;
            }
            else if (a[0, 2] == 'x' && a[1, 2] == 'x' && a[2, 2] == 'x')
            {
                return true;
            }
            else if (a[0, 0] == 'o' && a[0, 1] == 'o' && a[0, 2] == 'o')
            {
                return true;
            }
            else if (a[1, 0] == 'o' && a[1, 1] == 'o' && a[1, 2] == 'o')
            {
                return true;
            }
            else if (a[2, 0] == 'o' && a[2, 1] == 'o' && a[2, 2] == 'o')
            {
                return true;
            }
            else if (a[0, 0] == 'o' && a[1, 0] == 'o' && a[2, 0] == 'o')
            {
                return true;
            }
            else if (a[0, 1] == 'o' && a[1, 1] == 'o' && a[2, 1] == 'o')
            {
                return true;
            }
            else if (a[0, 2] == 'o' && a[1, 2] == 'o' && a[2, 2] == 'o')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
