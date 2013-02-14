using System;

class SandGlass
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        for (int row = 0; row <= (width / 2); row++)                            //Draw the upper part of the sand glass
        {
            for (int column = 0; column < width; column++)
            {
                bool downLimit = (row <= column);
                bool upperLimit = ((width - row) > column);
                if (downLimit && upperLimit)
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
        for (int row = (width / 2); row >= 1; row--)                            //Draw the down part of the sand glass
        {
            for (int column = 0; column < width; column++)
            {
                bool downLimit = (row - 1 <= column);
                bool upperLimit = ((width - row) >= column);
                if (downLimit && upperLimit)
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