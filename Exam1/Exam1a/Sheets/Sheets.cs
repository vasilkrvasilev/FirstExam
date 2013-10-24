using System;

class Sheets
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int position = 0; position < 11; position++)
        {
            int mask = 1 << position;
            int maskNumber = mask & number;
            int bit = maskNumber >> position;
            if (bit == 0)
            {
                Console.WriteLine("A{0}", 10 - position);
            }
        }
    }
}