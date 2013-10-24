using System;

class BitBall
{
    static void Main()
    {
        bool isTop = true;
        bool isTopGoal = true;
        bool isBottomGoal = true;
        int topGoal = 0;
        int bottomGoal = 0;
        byte[] top = new byte[8];
        for (int count = 0; count < 8; count++)
        {
            top[count] = byte.Parse(Console.ReadLine());
        }
        byte[] bottom = new byte[8];
        for (int count = 0; count < 8; count++)
        {
            bottom[count] = byte.Parse(Console.ReadLine());
        }
        byte[] field = new byte[8];
        for (int count = 0; count < 8; count++)
        {
            field[count] = (byte)(top[count] ^ bottom[count]);
        }
        for (int column = 0; column < 8; column++)
        {
            for (int row = 0; row < 8; row++)
            {
                int mask = 1 << column;
                int maskNumber = mask & field[row];
                int bit = maskNumber >> column;
                if (bit == 1)
                {
                    byte checkNumber = (byte)(field[row] & top[row]);
                    int checkMask = 1 << column;
                    int checkMaskNumber = checkMask & checkNumber;
                    int checkBit = checkMaskNumber >> column;
                    if (checkBit == 1)
                    {
                        isTop = true;
                    }
                    else
                    {
                        isTop = false;
                    }
                }
                if (isTop && bit == 1)
                {
                    for (int iteration = 1; iteration < 8 - row; iteration++)
                    {
                        int topMask = 1 << column;
                        int topMaskNumber = topMask & field[row + iteration];
                        int topBit = topMaskNumber >> column;
                        if (topBit == 1)
                        {
                            isTopGoal = false;
                        }
                    }
                    if (isTopGoal)
                    {
                        topGoal++;
                    }
                    isTopGoal = true;
                }
                else if (!isTop && bit == 1)
                {
                    for (int iteration = 1; iteration <= row; iteration++)
                    {
                        int bottomMask = 1 << column;
                        int bottomMaskNumber = bottomMask & field[row - iteration];
                        int bottomBit = bottomMaskNumber >> column;
                        if (bottomBit == 1)
                        {
                            isBottomGoal = false;
                        }
                    }
                    if (isBottomGoal)
                    {
                        bottomGoal++;
                    }
                    isBottomGoal = true;
                }
            }
        }
        Console.WriteLine("{0}:{1}", topGoal, bottomGoal);
    }
}