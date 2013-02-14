using System;
using System.Numerics;

class AstrologicalDigits
{
    static void Main()
    {
        string input = Console.ReadLine();
        string minusInput = input.Replace("-", "");
        string dotInput = minusInput.Replace(".", "");
        BigInteger number = BigInteger.Parse(dotInput);
        while (number > 10)
        {
            int[] countDigit = new int[9];
            for (int digit = 1; digit < 10; digit++)                            //Find how many different digits contains the number
            {
                string currentNumber = Convert.ToString(number);
                int numberDigits = currentNumber.Length;
                string currentDigit = Convert.ToString(digit);
                string digitInput = currentNumber.Replace(currentDigit, "");
                countDigit[digit - 1] = numberDigits - digitInput.Length;
            }
            number = 0;
            for (int position = 0; position < 9; position++)                   //Calculate the sum of the digits till it's more then 10
            {
                number += ((position + 1) * countDigit[position]);
            }
        }
        Console.WriteLine(number);
    }
}