using System;

class Carpets
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        for (int row = 0; row < size / 2; row++)
        {
            if (row % 2 == 0)
            {
                for (int column = 0; column < (size / 2) - row - 1; column++)
                {
                    Console.Write(".");
                }
                for (int column = 0; column < row / 2; column++)
                {
                    Console.Write("/ ");
                }
                Console.Write("/\\");
                for (int column = 0; column < row / 2; column++)
                {
                    Console.Write(" \\");
                }
                for (int column = 0; column < (size / 2) - row - 1; column++)
                {
                    Console.Write(".");
                }
            }
            else
            {
                for (int column = 0; column < (size / 2) - row - 1; column++)
                {
                    Console.Write(".");
                }
                for (int column = 0; column < (row + 1) / 2; column++)
                {
                    Console.Write("/ ");
                }
                for (int column = 0; column < (row + 1) / 2; column++)
                {
                    Console.Write(" \\");
                }
                for (int column = 0; column < (size / 2) - row - 1; column++)
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
        for (int row = size / 2 - 1; row >= 0; row--)
        {
            if (row % 2 == 0)
            {
                for (int column = 0; column < (size / 2) - row - 1; column++)
                {
                    Console.Write(".");
                }
                for (int column = 0; column < row / 2; column++)
                {
                    Console.Write("\\ ");
                }
                Console.Write("\\/");
                for (int column = 0; column < row / 2; column++)
                {
                    Console.Write(" /");
                }
                for (int column = 0; column < (size / 2) - row - 1; column++)
                {
                    Console.Write(".");
                }
            }
            else
            {
                for (int column = 0; column < (size / 2) - row - 1; column++)
                {
                    Console.Write(".");
                }
                for (int column = 0; column < (row + 1) / 2; column++)
                {
                    Console.Write("\\ ");
                }
                for (int column = 0; column < (row + 1) / 2; column++)
                {
                    Console.Write(" /");
                }
                for (int column = 0; column < (size / 2) - row - 1; column++)
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}