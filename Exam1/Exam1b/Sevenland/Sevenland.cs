using System;

class Sevenland
{
    static void Main()
    {
        string input = Console.ReadLine();
        int size = input.Length;
        int number = int.Parse(input);
        if (number % 10 < 6)
        {
            number++;
        }
        else
        {
            int tens = number / 10;
            if (tens % 10 < 6)
            {
                tens++;
                number = tens * 10;
            }
            else
            {
                tens = 0;
                int hundreds = number / 100;
                if (hundreds % 10 < 6)
                {
                    hundreds++;
                    number = hundreds * 100;
                }
                else
                {
                    number = 1000;
                }
            }
        }
        Console.WriteLine(number);
    }
}