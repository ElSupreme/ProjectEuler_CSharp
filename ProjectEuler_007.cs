// Project Euler (https://projecteuler.net/) code exercises
// Taken from FreeCodeCamp (https://www.freecodecamp.org/learn/project-euler/) lesson plan
// Not coded in JavaScript, but C#
// Code by JT Stukes

// Problem 7 - 10001st prime

/*
By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the nth prime number?
*/

Console.WriteLine(nthPrime(6)); // should write 13
Console.WriteLine(nthPrime(10)); // should write 29
Console.WriteLine(nthPrime(100)); // should write 541
Console.WriteLine(nthPrime(1000)); // should write 7919
Console.WriteLine(nthPrime(10001)); // should write 104743

long nthPrime(int goalPrime)
{
    int totalPrimesFound = 1; // two already counted
    long currentPrime = 2;
    long nextNumberToCheck = 3;
    while (totalPrimesFound < goalPrime)
    {
        if (IsPrime(nextNumberToCheck))
        {
            currentPrime = nextNumberToCheck;
            totalPrimesFound++;
        }
        nextNumberToCheck += 2;
    }
    return currentPrime;
}

// IsPrime() Copied from Problem 3
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