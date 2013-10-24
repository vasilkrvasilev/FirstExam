using System;

class AngryBits
{
    static void Main()
    {
        ushort[] number = new ushort[8];
        for (int position = 0; position < 8; position++)
        {
            number[position] = ushort.Parse(Console.ReadLine());
        }
        bool isPig = false;
        int deadPigs = 0;
        int path = 0;
        int points = 0;
        for (int position = 8; position < 16; position++)
        {
            for (int currentNumber = 0; currentNumber < 8; currentNumber++)
            {
                int mask = 1 << position;
                int maskNumber = mask & number[currentNumber];
                int bit = maskNumber >> position;
                if (bit == 1)
                {
                    int column = position;
                    for (int row = currentNumber - 1; row >= 0 && column > 0; row--)
                    {
                        if (!isPig)
                        {
                            column--;
                            path++;
                            int maskPig = 1 << column;
                            int maskNumberPig = maskPig & number[row];
                            int bitPig = maskNumberPig >> column;
                            if (bitPig == 1)
                            {
                                isPig = true;
                                for (int pigRow = Math.Max(row - 1, 0); pigRow <= Math.Min(row + 1, 7); pigRow++)
                                {
                                    for (int pigColumn = Math.Max(column - 1, 0); pigColumn <= Math.Min(column + 1, 7); pigColumn++)
                                    {
                                        int maskHit = ~(1 << pigColumn);
                                        int maskNumberHit = maskHit & number[pigRow];
                                        if (maskNumberHit != number[pigRow])
                                        {
                                            deadPigs++;
                                        }
                                        number[pigRow] = (ushort)maskNumberHit;
                                    }
                                }
                            }
                        }
                    }
                    int downRow = 0;
                    for (int downColumn = column - 1; downColumn >= 0 && downRow < 7; downColumn--)
                    {
                        if (!isPig)
                        {
                            downRow++;
                            path++;
                            int maskPig = 1 << downColumn;
                            int maskNumberPig = maskPig & number[downRow];
                            int bitPig = maskNumberPig >> downColumn;
                            if (bitPig == 1)
                            {
                                isPig = true;
                                for (int pigRow = Math.Max(downRow - 1, 0); pigRow <= Math.Min(downRow + 1, 7); pigRow++)
                                {
                                    for (int pigColumn = Math.Max(downColumn - 1, 0); pigColumn <= Math.Min(downColumn + 1, 7); pigColumn++)
                                    {
                                        int maskHit = ~(1 << pigColumn);
                                        int maskNumberHit = maskHit & number[pigRow];
                                        if (maskNumberHit != number[pigRow])
                                        {
                                            deadPigs++;
                                        }
                                        number[pigRow] = (ushort)maskNumberHit;
                                    }
                                }
                            }
                        }
                    }
                    int maskNumberSecond = ~mask & number[currentNumber];
                    number[currentNumber] = (ushort)maskNumberSecond;
                }
                points += (deadPigs * path);
                deadPigs = 0;
                path = 0;
                isPig = false;
            }
        }
        int sum = 0;
        for (int position = 0; position < 8; position++)
        {
            sum += number[position];
        }
        if (sum == 0)
        {
            Console.WriteLine("{0} Yes", points);
        }
        else
        {
            Console.WriteLine("{0} No", points);
        }

    }
}