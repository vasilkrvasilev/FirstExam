using System;

class ForestRoad
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        for (int row = 0; row < width; row++)                   //Draw the road to right and down
        {
            for (int column = 0; column < width; column++)
            {
                if (row == column)
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
        for (int row = 1; row < width; row++)                   //Draw the road to left and down
        {
            for (int column = width; column > 0; column--)
            {
                if (row == (column - 1))
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