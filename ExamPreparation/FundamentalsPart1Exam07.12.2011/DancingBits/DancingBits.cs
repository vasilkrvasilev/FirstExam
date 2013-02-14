using System;

class DancingBits
{
    static void Main()
    {
        int sequenceSize = int.Parse(Console.ReadLine());
        int numberInputs = int.Parse(Console.ReadLine());
        string input = "";
        for (int currentInput = 0; currentInput < numberInputs; currentInput++)             //Concatenate the number
        {
            int currentNumber = int.Parse(Console.ReadLine());
            string binaryNumber = Convert.ToString(currentNumber, 2);
            input += binaryNumber;
        }
        int numberDigits = input.Length;
        bool isOne = true;
        int currentSequence = 1;
        int dancingBits = 0;
        for (int currentPsition = 1; currentPsition < numberDigits; currentPsition++)
        {
            if (isOne)                                                                      //Count ones
            {
                if (input[currentPsition] == '1')
                {
                    currentSequence++;
                }
                else
                {
                    if (currentSequence == sequenceSize)                                   //Check is the sequence length correct
                    {
                        dancingBits++;
                        currentSequence = 0;
                    }
                    isOne = false;
                    currentSequence = 1;
                }
            }
            else                                                                           //Count zeros
            {
                if (input[currentPsition] == '0')
                {
                    currentSequence++;
                }
                else
                {
                    if (currentSequence == sequenceSize)                                   //Check is the sequence length correct
                    {
                        dancingBits++;
                        currentSequence = 0;
                    }
                    isOne = true;
                    currentSequence = 1;
                }
            }
        }
        if (currentSequence == sequenceSize)                                              //Check is the last sequence length correct
        {
            dancingBits++;
        }
        Console.WriteLine(dancingBits);
    }
}