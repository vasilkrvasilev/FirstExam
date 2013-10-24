using System;

class TripleRotaition
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int iteration = 0; iteration < 3; iteration++)
        {
            int lastDigit = number % 10;
            int changedNumber = number / 10;
            if (changedNumber != 0)
            {
                string textNumber = "" + lastDigit + changedNumber;
                number = int.Parse(textNumber);
            }
            else
            {
                number = lastDigit;
            }
        }
        Console.WriteLine(number);
    }
}