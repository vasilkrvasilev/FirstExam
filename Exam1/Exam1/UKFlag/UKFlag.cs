using System;

class UKFlag
{
    static void Main()
    {
        byte size = byte.Parse(Console.ReadLine());
        for (int row = 0; row < size / 2; row++)
        {
            for (int column = 0; column < size; column++)
            {
                if (column == row)
                {
                    Console.Write("\\");
                }
                else if (column == size / 2)
                {
                    Console.Write("|");
                }
                else if (column == size - 1 - row)
                {
                    Console.Write("/");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
        for (int column = 0; column < size; column++)
        {
            if (column == size / 2)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write("-");
            }
        }
        Console.WriteLine();
        for (int row = 0; row < size / 2; row++)
        {
            for (int column = 0; column < size; column++)
            {
                if (column == ((size / 2) - 1 - row))
                {
                    Console.Write("/");
                }
                else if (column == size / 2)
                {
                    Console.Write("|");
                }
                else if (column == ((size/ 2) + 1 + row))
                {
                    Console.Write("\\");
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