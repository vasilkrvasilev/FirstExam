using System;

class TribonacciTriangle
{
    static void Main()
    {
        long prePreviousNumber = long.Parse(Console.ReadLine());
        long previousNumber = long.Parse(Console.ReadLine());
        long currentNumber = long.Parse(Console.ReadLine());
        byte rows = byte.Parse(Console.ReadLine());
        int targetNumber = ((1 + rows) * rows) / 2;
        long[] matrix = new long[targetNumber];
        matrix[0] = prePreviousNumber;
        matrix[1] = previousNumber;
        matrix[2] = currentNumber;
        for (int count = 3; count < targetNumber; count++)
        {
            long nextNumber = prePreviousNumber + previousNumber + currentNumber;
            matrix[count] = nextNumber;
            prePreviousNumber = previousNumber;
            previousNumber = currentNumber;
            currentNumber = nextNumber;
        }
        for (int count = 1; count <= rows; count++)
        {
            for (int column = 1; column <= count; column++)
            {
                int currentMember = ((count * (count - 1)) / 2) + column - 1;
                Console.Write("{0} ", matrix[currentMember]);
            }
            Console.WriteLine();
        }
    }
}