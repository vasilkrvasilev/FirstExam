using System;

class MissCat2011
{
    static void Main()
    {
        int jury = int.Parse(Console.ReadLine());
        int[] votes = new int[jury];
        int[] cats = new int[10];
        for (int currentJury = 0; currentJury < jury; currentJury++)
        {
            votes[currentJury] = int.Parse(Console.ReadLine());
        }
        for (int currentVote = 0; currentVote < jury; currentVote++)
        {
            switch (votes[currentVote])                                 //Count the votes for every cat
            {
                case 1:
                    cats[0]++;
                    break;
                case 2:
                    cats[1]++;
                    break;
                case 3:
                    cats[2]++;
                    break;
                case 4:
                    cats[3]++;
                    break;
                case 5:
                    cats[4]++;
                    break;
                case 6:
                    cats[5]++;
                    break;
                case 7:
                    cats[6]++;
                    break;
                case 8:
                    cats[7]++;
                    break;
                case 9:
                    cats[8]++;
                    break;
                case 10:
                    cats[9]++;
                    break;
            }
        }
        int maxGrade = 0;
        int winner = 0;
        for (int currentCat = 0; currentCat < 10; currentCat++)         //Find the max grade and the relevant cat
        {
            if (cats[currentCat] > maxGrade)
            {
                maxGrade = cats[currentCat];
                winner = currentCat + 1;
            }
        }
        Console.WriteLine(winner);
    }
}