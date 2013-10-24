using System;

class Logo
{
    static void Main()
    {
        int side = int.Parse(Console.ReadLine());
        int size = (3 * side) - 2;
        int smallSide = (side + 1) / 2;
        for (int row = 0; row < side; row++)
        {
            for (int column = 0; column < size; column++)
            {
                if (smallSide - 1 + row == column)
                {
                    Console.Write("*");
                }
                else if (size - smallSide - row == column)
                {
                    Console.Write("*");
                }
                else if (smallSide - 1 - row == column && smallSide - row >= 0)
                {
                    Console.Write("*");
                }
                else if (size - smallSide + row == column && size - smallSide + row < size)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
        for (int row = 1; row < side; row++)
        {
            for (int column = 0; column < size; column++)
            {
                if ((size / 2) + row == column)
                {
                    Console.Write("*");
                }
                else if ((size / 2) - row == column)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
        for (int row = 1; row < side; row++)
        {
            for (int column = 0; column < size; column++)
            {
                if (((size / 2) - side + 1) + row == column)
                {
                    Console.Write("*");
                }
                else if (size - smallSide - row== column)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}