// Project Euler (https://projecteuler.net/) code exercises
// Taken from FreeCodeCamp (https://www.freecodecamp.org/learn/project-euler/) lesson plan
// Not coded in JavaScript, but C#
// Code by JT Stukes

// Problem 5 - Smallest Multiple

/*
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to n?
*/

Console.WriteLine(SmallestMult(5)); // should print 60
Console.WriteLine(SmallestMult(7)); // should print 420
Console.WriteLine(SmallestMult(10)); // should print 2520
Console.WriteLine(SmallestMult(13)); // should print 360360
Console.WriteLine(SmallestMult(20)); // should print 232792560

long SmallestMult(int numbersUpTo)
{
    long currentValueToCheck = numbersUpTo * (numbersUpTo - 1);
    while (true)
    {
        if (CheckAllNumbers(currentValueToCheck, numbersUpTo))
        {
            return currentValueToCheck;
        }
        currentValueToCheck += numbersUpTo;
    }
}

bool CheckAllNumbers(long numberToCheck, int largestDivisor)
{
    for (int i = largestDivisor; i >= 1; i--)
    {
        if (numberToCheck % i != 0)
        {
            return false;
        }
    }
    return true;
}

