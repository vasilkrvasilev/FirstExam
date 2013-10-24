using System;

class ExcelColumn
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        long code = 0;
        for (int iteration = number; iteration > 0; iteration--)
        {
            string letter = Console.ReadLine();
            long currentCode = letter[0] - 64;
            code = code + (currentCode * (long)Math.Pow(26, iteration - 1));
        }
        Console.WriteLine(code);
    }
}