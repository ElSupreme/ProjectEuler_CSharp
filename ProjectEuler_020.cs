// Project Euler (https://projecteuler.net/) code exercises
// Taken from FreeCodeCamp (https://www.freecodecamp.org/learn/project-euler/) lesson plan
// Not coded in JavaScript, but C#
// Code by JT Stukes

// Problem 20 - Factorial Digit Sum

/*
n! means n × (n − 1) × ... × 3 × 2 × 1

For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.

Find the sum of the digits n!
*/



Console.WriteLine(SumFactorialDigits(10)); // should write 27
Console.WriteLine(SumFactorialDigits(25)); // should write 27
Console.WriteLine(SumFactorialDigits(50)); // should write 27
Console.WriteLine(SumFactorialDigits(75)); // should write 27
Console.WriteLine(SumFactorialDigits(100)); // should write 27


int SumFactorialDigits(int factorialNumber)
{

    // copied from problem 16
    int stopNumber = factorialNumber * factorialNumber;
    int[] rollOver = new int[stopNumber + 1];
    int workingValue = 1;
    string answerReversed = "";

    for (int j = 1; j <= stopNumber; j++)
    {
        for (int i = 1; i <= stopNumber; i++) // calculate value for each order of magnitude
        {
            if (i <= factorialNumber)
            {
                            workingValue = workingValue * i;
            }
            workingValue = workingValue + rollOver[i];
            rollOver[i] = workingValue / 10;
            workingValue = workingValue % 10;
        }

        answerReversed = answerReversed + workingValue;
        workingValue = 0;
    }
    // Console.WriteLine(answerReversed);
    // at this point we have all digits

    int sumOfDigits = 0;

    for (int i = 0; i < answerReversed.Length; i++)
    {
        sumOfDigits += (int)char.GetNumericValue(answerReversed[i]);
    }

    return sumOfDigits;
}