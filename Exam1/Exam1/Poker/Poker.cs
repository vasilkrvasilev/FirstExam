using System;

class Poker
{
    static void Main()
    {
        int number;
        int[] array = new int[5];
        for (int iteration = 0; iteration < 5; iteration++)
        {
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out number);
            if (isNumber)
            {
                array[iteration] = number;
            }
            else
            {
                switch (input)
                {
                    case "J":
                        array[iteration] = 11;
                        break;
                    case "Q":
                        array[iteration] = 12;
                        break;
                    case "K":
                        array[iteration] = 13;
                        break;
                    case "A":
                        array[iteration] = 14;
                        break;
                }
            }
        }
        int[,] differentCards = new int[2,5];
        differentCards[0,0] = array[0];
        int card = 1;
        bool notAlone = false;
        for (int count = 1; count < 5; count++)
        {
            for (int position = 0; position < card; position++)
            {
                if (array[count] == differentCards[0, position])
                {
                    notAlone = true;
                }
            }
            if (!notAlone)
            {
                differentCards[0, card] = array[count];
                card++;
            }
            notAlone = false;
        }
        for (int position = 0; position < card; position++)
		{
			for (int count = 0; count < 5; count++)
			{
                if (array[count] == differentCards[0, position])
                {
                    differentCards[1, position]++;
                }
			} 
		}
        switch (card)
        {
            case 1:
                Console.WriteLine("Impossible");
                break;
            case 2:
                if (differentCards[1, 0] == 4 || differentCards[1, 1] == 4)
                {
                    Console.WriteLine("Four of a Kind");
                }
                if (differentCards[1, 0] == 3 || differentCards[1, 1] == 3)
                {
                    Console.WriteLine("Full House");
                }
                break;
            case 3:
                if (differentCards[1, 0] == 3 || differentCards[1, 1] == 3 || differentCards[1, 2] == 3)
                {
                    Console.WriteLine("Three of a Kind");
                }
                //Error: it must be used if - else instead two if statements
                if (differentCards[1, 0] == 1 || differentCards[1, 1] == 1 || differentCards[1, 2] == 1)
                {
                    Console.WriteLine("Two Pairs");
                }
                break;
            case 4:
                Console.WriteLine("One Pair");
                break;
            case 5:
                //Array.Sort(array);
                int[] order = new int[5];
                int minCard = 14;
                int add = 0;
                for (int iteration = 0; iteration < 5; iteration++)
			    {
                    for (int count = 0; count < 5; count++)
                    {
                        if (array[count] < minCard && array[count] > 0)
                        {
                            minCard = array[count];
                        }
                    }
                    order[iteration] = minCard + add;
                    for (int count = 0; count < 5; count++)
                    {
                        array[count] -= minCard;
                    }
                    add += minCard;
                    minCard = 14;
                }
                if (order[1] == order[0] + 1 && order[2] == order[1] + 1 && order[3] == order[2] + 1  && 
                    (order[4] == order[3] + 1 || order[4] == 14))
                {
                    Console.WriteLine("Straight");
                }
                else
                {
                    Console.WriteLine("Nothing");
                }
                break;
        }
    }
}