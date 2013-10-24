using System;

class NextDate
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 1 || month == 10 || month == 12) &&
            day == 31)
        {
            day = 1;
            if (month == 12)
            {
                month = 1;
                year++;
            }
            else
            {
                month++;
            }
        }
        else if ((month == 4 || month == 6 || month == 9 || month == 11) && day == 30)
        {
            day = 1;
            month++;
        }
        else if (month == 2)
        {
            if (day == 28)
            {
                if (year % 4 != 0)
                {
                    day = 1;
                    month++;
                }
                else
                {
                    day++;
                }
            }
            else if (year % 4 == 0 && day == 29)
            {
                day = 1;
                month++;
            }
            else
            {
                day++;
            }
        }
        else
        {
            day++;
        }
        DateTime date = new DateTime(year, month, day);
        Console.WriteLine("{0:d.M.yyyy}", date);
        //second way
        //int day = int.Parse(Console.ReadLine());
        //int month = int.Parse(Console.ReadLine());
        //int year = int.Parse(Console.ReadLine());
        //DateTime date = new DateTime(year, month, day);
        //DateTime oneDayMore = date.AddDays(1);
        //Console.WriteLine("{0:d.M.yyyy}", oneDayMore);
    }
}