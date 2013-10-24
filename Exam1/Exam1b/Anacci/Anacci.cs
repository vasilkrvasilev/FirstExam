using System;

class Anacci
{
    static void Main()
    {
        string firstLetter = Console.ReadLine();
        int previousCode = firstLetter[0] - 64;
        string secondLetter = Console.ReadLine();
        int currentCode = secondLetter[0] - 64;
        int rows = int.Parse(Console.ReadLine());
        int targetNumber = ((rows - 1) * 2) + 1;
        int spaces = 0;
        string[] matrix = new string[Math.Max(targetNumber,2)];
        matrix[0] = firstLetter;
        matrix[1] = secondLetter;
        for (int count = 2; count < targetNumber; count++)
        {
            int nextCode = (previousCode + currentCode) % 26;
            if (nextCode == 0)
            {
                nextCode = 26;
            }
            string nextLetter = ((char)(nextCode + 64)).ToString();
            matrix[count] = nextLetter;
            previousCode = currentCode;
            currentCode = nextCode;
        }
        Console.WriteLine(matrix[0]);
        for (int count = 1; count < rows; count++)
        {
            Console.Write("{0}", matrix[((count - 1) * 2) + 1]);
            for (int iteration = 0; iteration < spaces; iteration++)
            {
                Console.Write(" ");
            }
            Console.Write("{0}", matrix[count * 2]);
            Console.WriteLine();
            spaces++;
        }
    }
}