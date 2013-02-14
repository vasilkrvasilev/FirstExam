using System;

class FirTree
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        int width = ((height - 2) * 2) + 1;
        for (int row = 0; row < (height - 1); row++)                    //Draw the stem of the tree
        {
            for (int column = 0; column < width; column++)
            {
                bool downLimit = (((width / 2) - row) <= column);
                bool upperLimit = (((width / 2) + row) >= column);
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
        for (int column = 0; column < width; column++)                  //Draw the stem of the tree
        {
            if (column == (width / 2))
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(".");
            }
        }
    }
}