using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger previousPreviousNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger previousNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger currentNumber = BigInteger.Parse(Console.ReadLine());
        int targetNumber = int.Parse(Console.ReadLine());
        if (targetNumber == 1)
        {
            Console.WriteLine(previousPreviousNumber);
        }
        else if (targetNumber == 2)
        {
            Console.WriteLine(previousNumber);
        }
        else
        {
            for (int count = 4; count <= targetNumber; count++)
            {
                BigInteger nextNumber = previousPreviousNumber + previousNumber + currentNumber;
                previousPreviousNumber = previousNumber;
                previousNumber = currentNumber;
                currentNumber = nextNumber;
            }
            Console.WriteLine(currentNumber);
        }
    }
}