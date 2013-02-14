using System;

class FallDown
{
    static void Main()
    {
        int[] ones = new int[8];
        for (int currentNumber = 0; currentNumber < 8; currentNumber++)         //Calculate the number of full cells in every column
        {
            byte number = byte.Parse(Console.ReadLine());
            for (int bit = 0; bit < 8; bit++)
            {
                int mask = 1 << bit;
                int maskNumber = mask & number;
                if (maskNumber != 0)
                {
                    ones[bit]++;
                }
            }
        }
        string[] binaryNumbers = new string[8];
        for (int number = 0; number < 8; number++)                             //Create the fall down binary numbers
        {
            for (int bit = 7; bit >= 0; bit--)
            {
                if (ones[bit] > 0)
                {
                    binaryNumbers[number] += "1";
                    ones[bit]--;
                }
                else
                {
                    binaryNumbers[number] += "0";
                }
            }
        }
        for (int number = 7; number >= 0; number--)                           //Convert and print the fall down numbers
        {
            int currentNumber = Convert.ToInt32(binaryNumbers[number], 2);
            Console.WriteLine(currentNumber);
        }
    }
}