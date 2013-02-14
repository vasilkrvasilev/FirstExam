using System;

class WeAllLoveBits
{
    static void Main()
    {
        //magicNumber = (number ^ tildaNumber) & umlautNumber
        int iteration = int.Parse(Console.ReadLine());
        int[] magicNumbers = new int[iteration];
        for (int currentIteration = 0; currentIteration < iteration; currentIteration++)
        {
            int number = int.Parse(Console.ReadLine());
            string binaryNumber = Convert.ToString(number, 2);
            int numberDigits = binaryNumber.Length;
            string ones = new string('1', numberDigits);
            int onesNumber = Convert.ToInt32(ones, 2);
            int tildaNumber = number ^ onesNumber;                                         //Find tildaNumber
            string umlaut = "";
            for (int digit = (numberDigits - 1); digit >= 0; digit--)
            {
                umlaut += binaryNumber[digit];
            }
            int umlautNumber = Convert.ToInt32(umlaut, 2);                                 //Find umlautNumber
            magicNumbers[currentIteration] = (number ^ tildaNumber) & umlautNumber;        //Calculate magicNumber
        }
        for (int currentIteration = 0; currentIteration < iteration; currentIteration++)
        {
            Console.WriteLine(magicNumbers[currentIteration]);
        }
    }
}