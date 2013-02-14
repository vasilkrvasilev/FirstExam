using System;

class Lines
{
    static void Main()
    {
        byte[] numbers = new byte[8];
        for (int currentNumber = 0; currentNumber < 8; currentNumber++)
        {
            numbers[currentNumber] = byte.Parse(Console.ReadLine());
        }
        byte maxLine = 0;
        byte currentMax = 0;
        byte currentLine = 0;
        byte countLine = 0;
        for (int position = 0; position < 8; position++)                //Find the max length and number of lines on the horizontal
        {
            for (int bit = 0; bit < 8; bit++)
            {
                int mask = 1 << bit;
                int maskNumber = mask & numbers[position];
                if (maskNumber != 0)                                    //Find the full cells and calculate the length of the current line
                {
                    currentLine++;
                    if (currentLine > currentMax)
                    {
                        currentMax = currentLine;
                    }
                }
                if (maskNumber == 0 || bit == 7)                        //End the current line and find the max lendth and number of lines
                {
                    if (currentMax == maxLine)
                    {
                        countLine++;
                    }
                    if (currentMax > maxLine)
                    {
                        maxLine = currentMax;
                        countLine = 1;
                    }
                    currentLine = 0;
                    currentMax = 0;
                }
            }
        }
        for (int bit = 0; bit < 8; bit++)                               //Find the max length and number of lines on the vertical
        {
            for (int position = 0; position < 8; position++)
            {
                int mask = 1 << bit;
                int maskNumber = mask & numbers[position];
                if (maskNumber != 0)                                    //Find the full cells and calculate the length of the current line
                {
                    currentLine++;
                    if (currentLine > currentMax)
                    {
                        currentMax = currentLine;
                    }
                }
                if (maskNumber == 0 || position == 7)                   //End the current line and find the max lendth and number of lines
                {
                    if (currentMax == maxLine)
                    {
                        countLine++;
                    }
                    if (currentMax > maxLine)
                    {
                        maxLine = currentMax;
                        countLine = 1;
                    }
                    currentLine = 0;
                    currentMax = 0;
                }
            }
        }
        if (maxLine == 1)                                              //Recalculate the number of lines if the max length is equal to 1
        {
            countLine /= 2;
        }
        Console.WriteLine(maxLine);
        Console.WriteLine(countLine);
    }
}