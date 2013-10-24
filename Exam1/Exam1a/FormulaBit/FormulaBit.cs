using System;

class FormulaBit
{
    static void Main()
    {
        byte[] number = new byte[8];
        for (int position = 0; position < 8; position++)
        {
            number[position] = byte.Parse(Console.ReadLine());
        }
        int path = 0;
        int turns = 0;
        bool isWest = false;
        bool isSouth = true;
        bool noPath = false;
        byte row = 0;
        byte column = 0;
        byte bitSouth = 0;
        byte bitWest = 0;
        byte bitNorth = 0;
        int mask = 1 << column;
        int maskNumber = mask & number[row];
        bitSouth = (byte)(maskNumber >> column);
        if (bitSouth == 0)
        {
            path++;
        }
        else
        {
            noPath = true;
        }
        while (!noPath && (row < 7 || column < 7))
        {
            if (isSouth && !isWest)
            {
                if (row < 7)
                {
                    int maskSouth = 1 << column;
                    int maskNumberSouth = maskSouth & number[row + 1];
                    bitSouth = (byte)(maskNumberSouth >> column);
                }
                else
                {
                    bitSouth = (byte)1;
                }
                if (column < 7)
                {
                    int maskWest = 1 << column + 1;
                    int maskNumberWest = maskWest & number[row];
                    bitWest = (byte)(maskNumberWest >> column + 1);
                }
                else
                {
                    bitWest = (byte)1;
                }
                if (bitSouth == 0)
                {
                    row++;
                    path++;
                }
                else if (bitWest == 0)
                {
                    column++;
                    path++;
                    turns++;
                    isWest = true;
                }
                else
                {
                    noPath = true;
                }
            }
            else if (!isSouth && !isWest)
            {
                if (row > 0)
                {
                    int maskNorth = 1 << column;
                    int maskNumberNorth = maskNorth & number[row - 1];
                    bitNorth = (byte)(maskNumberNorth >> column);
                }
                else
                {
                    bitNorth = (byte)1;
                }
                if (column < 7)
                {
                    int maskWest = 1 << column + 1;
                    int maskNumberWest = maskWest & number[row];
                    bitWest = (byte)(maskNumberWest >> column + 1);
                }
                else
                {
                    bitWest = (byte)1;
                }
                if (bitNorth == 0)
                {
                    row--;
                    path++;
                }
                else if (bitWest == 0)
                {
                    column++;
                    path++;
                    turns++;
                    isWest = true;
                }
                else
                {
                    noPath = true;
                }
            }
            else if (isWest)
            {
                if (row < 7)
                {
                    int maskSouth = 1 << column;
                    int maskNumberSouth = maskSouth & number[row + 1];
                    bitSouth = (byte)(maskNumberSouth >> column);
                }
                else
                {
                    bitSouth = (byte)1;
                }
                if (row > 0)
                {
                    int maskNorth = 1 << column;
                    int maskNumberNorth = maskNorth & number[row - 1];
                    bitNorth = (byte)(maskNumberNorth >> column);
                }
                else
                {
                    bitNorth = (byte)1;
                }
                if (column < 7)
                {
                    int maskWest = 1 << column + 1;
                    int maskNumberWest = maskWest & number[row];
                    bitWest = (byte)(maskNumberWest >> column + 1);
                }
                else
                {
                    bitWest = (byte)1;
                }
                if (bitWest == 0)
                {
                    column++;
                    path++;
                }
                else if (bitSouth == 0 && !isSouth)
                {
                    row++;
                    path++;
                    turns++;
                    isSouth = true;
                    isWest = false;
                }
                else if (bitNorth == 0 && isSouth)
                {
                    row--;
                    path++;
                    turns++;
                    isSouth = false;
                    isWest = false;
                }
                else
                {
                    noPath = true;
                }
            }
        }
        if (row == 7 && column == 7)
        {
            Console.WriteLine("{0} {1}", path, turns);
        }
        else
        {
            Console.WriteLine("No {0}", path);
        }
    }
}