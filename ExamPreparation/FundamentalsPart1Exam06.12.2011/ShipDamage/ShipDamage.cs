using System;

class ShipDamage
{
    static void Main()
    {
        int shipFirstAbscissa = int.Parse(Console.ReadLine());
        int shipFirstOrdinate = int.Parse(Console.ReadLine());
        int shipSecondAbscissa = int.Parse(Console.ReadLine());
        int shipSecondOrdinate = int.Parse(Console.ReadLine());
        int smallerAbscissa = Math.Min(shipFirstAbscissa, shipSecondAbscissa);                          //Build the ship
        int biggerAbscissa = Math.Max(shipFirstAbscissa, shipSecondAbscissa);
        int smallerOrdinate = Math.Min(shipFirstOrdinate, shipSecondOrdinate);
        int biggerOrdinate = Math.Max(shipFirstOrdinate, shipSecondOrdinate);
        int horizon = int.Parse(Console.ReadLine());
        int[,] point = new int[3, 2];
        int damage = 0;
        for (int currentPoint = 0; currentPoint < 3; currentPoint++)
        {
            point[currentPoint, 0] = int.Parse(Console.ReadLine());
            int currentOrdinate = int.Parse(Console.ReadLine());
            int horizonDistance = horizon - currentOrdinate;
            point[currentPoint, 1] = currentOrdinate + (2 * horizonDistance);                           //Find the coordinates of the shots
            bool isCorner = ((point[currentPoint, 0] == smallerAbscissa) || (point[currentPoint, 0] == biggerAbscissa)) &&
                ((point[currentPoint, 1] == smallerOrdinate) || (point[currentPoint, 1] == biggerOrdinate));
            bool isVerticalEdge = ((point[currentPoint, 0] == smallerAbscissa) || (point[currentPoint, 0] == biggerAbscissa)) &&
                ((point[currentPoint, 1] > smallerOrdinate) && (point[currentPoint, 1] < biggerOrdinate));
            bool isHorizontalEdge = ((point[currentPoint, 0] > smallerAbscissa) && (point[currentPoint, 0] < biggerAbscissa)) &&
                ((point[currentPoint, 1] == smallerOrdinate) || (point[currentPoint, 1] == biggerOrdinate));
            bool isInside = (point[currentPoint, 0] > smallerAbscissa) && (point[currentPoint, 0] < biggerAbscissa) &&
                (point[currentPoint, 1] > smallerOrdinate) && (point[currentPoint, 1] < biggerOrdinate); //Check where the shots fell
            if (isCorner)
            {
                damage += 25;
            }
            if (isVerticalEdge || isHorizontalEdge)
            {
                damage += 50;
            }
            if (isInside)
            {
                damage += 100;                                                                            //Calculate the damage
            }
        }
        Console.WriteLine("{0}%", damage);
    }
}