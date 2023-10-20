// Project Euler (https://projecteuler.net/) code exercises
// Taken from FreeCodeCamp (https://www.freecodecamp.org/learn/project-euler/) lesson plan
// Not coded in JavaScript, but C#
// Code by JT Stukes

// Problem 3 - Largest Prime Factor

/*
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the given number?
*/

Console.WriteLine(LargestPrimeFactor(2)); // should return 2
Console.WriteLine(LargestPrimeFactor(3)); // should return 3
Console.WriteLine(LargestPrimeFactor(5)); // should return 5
Console.WriteLine(LargestPrimeFactor(7)); // should return 7
Console.WriteLine(LargestPrimeFactor(8)); // should return 2
Console.WriteLine(LargestPrimeFactor(13195)); // should return 29
Console.WriteLine(LargestPrimeFactor(600851475143)); // should return 6857

long LargestPrimeFactor(long numberToFactor)
{
    long largestWorkingFactor = 1;
    long nextNumber = 1;

    if(IsPrime(numberToFactor))
    {
        return numberToFactor;
    }

    while (nextNumber * nextNumber <= numberToFactor)
    {
        if (IsPrime(nextNumber))
        {
            if (numberToFactor % nextNumber == 0)
            {
                largestWorkingFactor = nextNumber;
            }
        }
        nextNumber++;
    }

    return largestWorkingFactor;
}

bool IsPrime(long number)
{
    long nextFactor = 2;

    while (nextFactor * nextFactor <= number)
    {
        if (number % nextFactor == 0)
        {
            return false;
        }
        nextFactor++;
    }
    return true;
}