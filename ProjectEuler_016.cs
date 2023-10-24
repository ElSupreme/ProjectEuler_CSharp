// Project Euler (https://projecteuler.net/) code exercises
// Taken from FreeCodeCamp (https://www.freecodecamp.org/learn/project-euler/) lesson plan
// Not coded in JavaScript, but C#
// Code by JT Stukes

// Problem 16 - Power digit sum

/*
215 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

What is the sum of the digits of the number 2exponent?
*/


Console.WriteLine(PowerDigitSum(15)); // should write 26
Console.WriteLine(PowerDigitSum(128)); // should write 166
Console.WriteLine(PowerDigitSum(1000)); // should write 1366


int PowerDigitSum(int exponent)
{
    // need array to keep rollover amounts with position
    int[] rollOver = new int[exponent];
    int workingValue = 1;
    string answerReversed = "";

    for (int j = 0; j < exponent; j++)
    {
        for (int i = 0; i < exponent; i++) // calculate value for each order of magnitude
        {
            workingValue = workingValue * 2;
            workingValue = workingValue + rollOver[i];
            rollOver[i] = workingValue / 10;
            workingValue = workingValue % 10;
        }

        answerReversed = answerReversed + workingValue;
        workingValue = 0;
    }
    
    // at this point we have all digits

    int sumOfDigits = 0;

    for (int i = 0; i < answerReversed.Length; i++)
    {
        sumOfDigits += (int)char.GetNumericValue(answerReversed[i]);
    }
    
    return sumOfDigits;
}

