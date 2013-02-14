using System;

class Pillars
{
    static void Main()
    {
        int[] ones = new int[8];
        bool noPillars = true;
        for (int currentNumber = 0; currentNumber < 8; currentNumber++)       //Calculate the bits at every column
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
        for (int position = 7; position >= 0; position--)                    //Calculate the sums of bits for every position of the pillar
        {
            int left = 0;
            int right = 0;
            for (int leftRank = 7; leftRank > position; leftRank--)
            {
                left += ones[leftRank];
            }
            for (int rightRank = 0; rightRank < position; rightRank++)
            {
                right += ones[rightRank];
            }
            if (left == right)                                              //Check if the sums of the bits on left and right side
            {                                                               //of the pillar are equal
                Console.WriteLine(position);
                Console.WriteLine(left);
                noPillars = false;
                break;
            }
        }
        if (noPillars)
        {
            Console.WriteLine("No");
        }
    }
}