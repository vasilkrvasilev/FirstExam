using System;

class Trapeze
{
    static void Main()
    {
        int trapezoidSide = int.Parse(Console.ReadLine());
        int position = 1;
        for (int dot = 1; dot <= trapezoidSide; dot++)                          //Draw the first side of the trapeze
        {
            Console.Write(".");
        }
        for (int dot = 1; dot <= trapezoidSide; dot++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        for (int row = 1; row < trapezoidSide; row++)                          //Draw the second and third side of the trapeze
        {
            for (int dot = 1; dot < 2 * trapezoidSide - 1; dot++)
            {
                Console.Write(".");
                if (dot == trapezoidSide - position)
                {
                    Console.Write("*");
                }
            }
            position++;
            Console.Write("*");
            Console.WriteLine();
        }
        for (int star = 1; star <= 2 * trapezoidSide; star++)                  //Draw the fourth side of the trapeze
        {
            Console.Write("*");
        }
    }
}