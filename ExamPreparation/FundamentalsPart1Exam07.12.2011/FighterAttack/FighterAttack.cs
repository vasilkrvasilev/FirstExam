using System;

class FighterAttack
{
    static void Main()
    {
        int plantFirstAbscissa = int.Parse(Console.ReadLine());
        int plantFirstOrdinate = int.Parse(Console.ReadLine());
        int plantSecondAbscissa = int.Parse(Console.ReadLine());
        int plantSecondOrdinate = int.Parse(Console.ReadLine());
        int smallerAbscissa = Math.Min(plantFirstAbscissa, plantSecondAbscissa);
        int biggerAbscissa = Math.Max(plantFirstAbscissa, plantSecondAbscissa);
        int smallerOrdinate = Math.Min(plantFirstOrdinate, plantSecondOrdinate);
        int biggerOrdinate = Math.Max(plantFirstOrdinate, plantSecondOrdinate);                 //Build the plant
        int fighterAbscissa = int.Parse(Console.ReadLine());
        int fighterOrdinate = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());
        int firstHitAbscissa = fighterAbscissa + distance;
        int secondHitAbscissa = firstHitAbscissa + 1;
        int thirdHitOrdinate = fighterOrdinate + 1;
        int fourthHitOrdinate = fighterOrdinate - 1;
        int[,] hits =                                                                          //Find the coordinates of the shots
        {
            {firstHitAbscissa, fighterOrdinate}, 
            {secondHitAbscissa, fighterOrdinate},
            {firstHitAbscissa, thirdHitOrdinate}, 
            {firstHitAbscissa, fourthHitOrdinate}
        };
        bool[] isInside = new bool[4];
        for (int currentHit = 0; currentHit < 4; currentHit++)                                 //Check where the shots fell
        {
            bool check = (hits[currentHit, 0] >= smallerAbscissa) && (hits[currentHit, 0] <= biggerAbscissa) &&
                (hits[currentHit, 1] >= smallerOrdinate) && (hits[currentHit, 1] <= biggerOrdinate);
            if (check)
            {
                isInside[currentHit] = true;
            }
        }
        int damage = 0;
        if (isInside[0])                                                                       //Calculate the damage
        {
            damage += 100;
        }
        if (isInside[1])
        {
            damage += 75;
        }
        if (isInside[2])
        {
            damage += 50;
        }
        if (isInside[3])
        {
            damage += 50;
        }
        Console.WriteLine("{0}%", damage);
    }
}