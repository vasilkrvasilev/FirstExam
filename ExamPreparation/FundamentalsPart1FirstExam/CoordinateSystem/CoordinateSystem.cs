using System;

class CoordinateSystem
{
    static void Main()
    {
        double abscissa = double.Parse(Console.ReadLine());
        double ordinate = double.Parse(Console.ReadLine());
        int location;
        if ((abscissa == 0) && (ordinate == 0))
        {
            location = 0;
        }
        else if ((abscissa == 0) && (ordinate != 0))
        {
            location = 5;
        }
        else if ((abscissa != 0) && (ordinate == 0))
        {
            location = 6;
        }
        else if ((abscissa > 0) && (ordinate > 0))
        {
            location = 1;
        }
        else if ((abscissa < 0) && (ordinate > 0))
        {
            location = 2;
        }
        else if ((abscissa < 0) && (ordinate < 0))
        {
            location = 3;
        }
        else
        {
            location = 4;
        }
        Console.WriteLine(location);
    }
}