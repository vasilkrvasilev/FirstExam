using System;

class OddNumber
{
    static void Main()
    {
        int members = int.Parse(Console.ReadLine());
        long[] numbers = new long[members];
        for (int position = 0; position < members; position++)
        {
            string input = Console.ReadLine();
            numbers[position] = long.Parse(input);
        }
        long xorResult = numbers[0];
        for (int position = 1; position < members; position++)
        {
            xorResult ^= numbers[position];                         //a ^ a = 0 and 0 ^ a = a
        }
        Console.WriteLine(xorResult);
    }
}