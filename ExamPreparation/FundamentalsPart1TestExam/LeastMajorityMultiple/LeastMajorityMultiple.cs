using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        int[] numbers = new int[5];
        for (int posiiton = 0; posiiton < 5; posiiton++)
        {
            numbers[posiiton] = int.Parse(Console.ReadLine());
        }
        int maxSubsets = (int)Math.Pow(2, 5) - 1;
        int[] currentMultiples = new int[3];
        int[] prime = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
        int LeastMajorityMultiple = 1000000000;
        for (int currentSubset = 1; currentSubset <= maxSubsets; currentSubset++)     //Create all possible subsets
        {
            int multiplePosition = 0;
            string currentNumber = Convert.ToString(currentSubset, 2);
            string modifiedNumber = currentNumber.Replace("1", "");
            if (currentNumber.Length - modifiedNumber.Length == 3)                    //Find all possible subsets of three numbers
            {
                for (int bitPosition = 0; bitPosition < 5; bitPosition++)             //Find the numbers of current subset
                {
                    if (((currentSubset >> bitPosition) & 1) == 1)
                    {
                        currentMultiples[multiplePosition] = numbers[bitPosition];
                        multiplePosition++;
                    }
                }
                int currentLeastMultiple = 1;
                int primePosition = 0;
                int currentNumberOne = currentMultiples[0];
                int currentNumberTwo = currentMultiples[1];
                int currentNumberThree = currentMultiples[2];
                while (primePosition < prime.Length)                                  //Divide the numbers by every prime number to 100
                {                                                                     //till one of them is divisible to the current prime
                    int reminderOne = currentNumberOne % prime[primePosition];
                    int reminderTwo = currentNumberTwo % prime[primePosition];
                    int reminderThree = currentNumberThree % prime[primePosition];
                    if (reminderOne == 0 || reminderTwo == 0 || reminderThree == 0)   //Calculate the current Least Majority Multiple
                    {
                        currentLeastMultiple *= prime[primePosition];
                    }
                    if (reminderOne != 0 && reminderTwo != 0 && reminderThree != 0)
                    {
                        primePosition++;
                    }
                    if (reminderOne == 0)
                    {
                        currentNumberOne /= prime[primePosition];
                    }
                    if (reminderTwo == 0)
                    {
                        currentNumberTwo /= prime[primePosition];
                    }
                    if (reminderThree == 0)
                    {
                        currentNumberThree /= prime[primePosition];
                    }
                }
                if (currentLeastMultiple < LeastMajorityMultiple)                    //Find the smallest Least Majority Multiple
                {
                    LeastMajorityMultiple = currentLeastMultiple;
                }
            }
        }
        Console.WriteLine(LeastMajorityMultiple);
    }
}