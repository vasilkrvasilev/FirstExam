using System;

class BinaryDigitsCount
{
    static void Main()
    {
        int binaryDigit = int.Parse(Console.ReadLine());
        int number = int.Parse(Console.ReadLine());
        uint[] integerNumbers = new uint[number];
        for (int position = 0; position < number; position++)
        {
            integerNumbers[position] = uint.Parse(Console.ReadLine());
        }
        int[] numberDigits = new int[number];
        for (int position = 0; position < number; position++)                       //Calculate the number of 1 or 0 bits in the number
        {
            string currentNumber = Convert.ToString(integerNumbers[position], 2);
            string modifiedNumber;
            if (binaryDigit == 0)
            {
                modifiedNumber = currentNumber.Replace("1", "");
            }
            else
            {
                modifiedNumber = currentNumber.Replace("0", "");
            }
            numberDigits[position] = modifiedNumber.Length;
        }
        for (int position = 0; position < number; position++)
        {
            Console.WriteLine(numberDigits[position]);
        }
    }
}