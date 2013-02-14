using System;

class MathExpression
{
    static void Main()
    {
        //(N^2 + 1/(M*P) + 1337))/(N - 128.523123123*P) + sin(M/180)
        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        int integerM = (int)m;
        double sin = Math.Sin(integerM % 180);                  //Calculate sin(M/180)
        double nomerator = (n * n) + (1 / (m * p)) + 1337;      //Calculate N^2 + 1/(M*P) + 1337)
        double denominator = n - (128.523123123 * p);           //Calculate N - 128.523123123*P
        double result = (nomerator / denominator) + sin;        //Calculate the result
        Console.WriteLine("{0:F6}", result);
    }
}