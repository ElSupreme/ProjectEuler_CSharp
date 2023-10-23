// Project Euler (https://projecteuler.net/) code exercises
// Taken from FreeCodeCamp (https://www.freecodecamp.org/learn/project-euler/) lesson plan
// Not coded in JavaScript, but C#
// Code by JT Stukes

// Problem 10 - Summation of primes

/*
The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below n.
*/

Console.WriteLine(PrimeSummation(17)); // should write 41
Console.WriteLine(PrimeSummation(2001)); // should write 277050
Console.WriteLine(PrimeSummation(140759)); // should write 873608362
Console.WriteLine(PrimeSummation(2000000)); // should write 142913828922

long PrimeSummation(int primesBelow)
{
    long primeSum = 2;
    if (primesBelow < 2)
    {
        Console.WriteLine("No Primes");
        return 0;
    }
    else if (primesBelow == 2)
    {
        return 2;
    }
    else
    {
        for (int i = 3; i < primesBelow; i += 2)
        {
            if (IsPrime(i))
            { 
                primeSum += i;
            }
        }
        return primeSum;
    }
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

