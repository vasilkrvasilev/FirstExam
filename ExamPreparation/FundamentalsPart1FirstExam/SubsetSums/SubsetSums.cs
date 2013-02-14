using System;

class SubsetSums
{
    static void Main()
    {
        long sum = long.Parse(Console.ReadLine());
        int members = int.Parse(Console.ReadLine());
        long[] numbers = new long[members];
        for (int posiiton = 0; posiiton < members; posiiton++)
        {
            numbers[posiiton] = long.Parse(Console.ReadLine());
        }
        int subsets = 0;
        int maxSubsets = (int)Math.Pow(2, members) - 1;
        for (int currentSubset = 1; currentSubset <= maxSubsets; currentSubset++)       //Create all possible subsets
        {
            long currentSum = 0;
            for (int bitPosition = 0; bitPosition < members; bitPosition++)             //Calculate the sum of every subset
            {
                if (((currentSubset >> bitPosition) & 1) == 1)                          //If the bit is 1 the number is part of the subset
                {
                    currentSum += numbers[bitPosition];
                }
            }
            if (currentSum == sum)                                                      //Check is the sum correct
            {
                subsets++;
            }
        }
        Console.WriteLine(subsets);
    }
}