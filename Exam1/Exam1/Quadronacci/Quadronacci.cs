using System;

class Quadronacci
{
    static void Main()
    {
        long prePrePreviousNumber = long.Parse(Console.ReadLine());
        long prePreviousNumber = long.Parse(Console.ReadLine());
        long previousNumber = long.Parse(Console.ReadLine());
        long currentNumber = long.Parse(Console.ReadLine());
        byte rows = byte.Parse(Console.ReadLine());
        byte columns = byte.Parse(Console.ReadLine());
        int targetNumber = rows * columns;
        long[,] matrix = new long[rows, columns];
        
        if (targetNumber == 1)
        {
            matrix[0,0] = prePrePreviousNumber;
        }
        else if (targetNumber == 2)
        {
            matrix[0,0] = prePrePreviousNumber;
            matrix[0,1] = prePreviousNumber;
        }
        else if (targetNumber == 3)
        {
            matrix[0, 0] = prePrePreviousNumber;
            matrix[0, 1] = prePreviousNumber;
            matrix[0, 2] = previousNumber;
        }
        else if (targetNumber == 4)
        {
            matrix[0, 0] = prePrePreviousNumber;
            matrix[0, 1] = prePreviousNumber;
            matrix[0, 2] = previousNumber;
            matrix[0, 3] = currentNumber;
        }
        else
        {
            matrix[0, 0] = prePrePreviousNumber;
            matrix[0, 1] = prePreviousNumber;
            matrix[0, 2] = previousNumber;
            matrix[0, 3] = currentNumber;
            for (int count = 0; count < rows; count++)
            {
                if (count == 0)
                {
                    for (int position = 4; position < columns; position++)
                    {
                        long nextNumber = prePrePreviousNumber + prePreviousNumber + previousNumber + currentNumber;
                        matrix[count, position] = nextNumber;
                        prePrePreviousNumber = prePreviousNumber;
                        prePreviousNumber = previousNumber;
                        previousNumber = currentNumber;
                        currentNumber = nextNumber;
                    }
                }
                else
                {
                    for (int position = 0; position < columns; position++)
                    {
                        long nextNumber = prePrePreviousNumber + prePreviousNumber + previousNumber + currentNumber;
                        matrix[count, position] = nextNumber;
                        prePrePreviousNumber = prePreviousNumber;
                        prePreviousNumber = previousNumber;
                        previousNumber = currentNumber;
                        currentNumber = nextNumber;
                    }
                }
            }
        }
        for (int count = 0; count < rows; count++)
        {
            for (int position = 0; position < columns; position++)
            {
                Console.Write("{0} ", matrix[count, position]);
            }
            Console.WriteLine();
        }
    }
}