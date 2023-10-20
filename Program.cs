// Project Euler (https://projecteuler.net/) code exercises
// Taken from FreeCodeCamp (https://www.freecodecamp.org/learn/project-euler/) lesson plan
// Not coded in JavaScript, but C#
// Code by JT Stukes

// Problem 1 - Multiples of 3 and 5

/*
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below the provided parameter value *number*.
*/

Console.WriteLine(MultiplesOfThreeAndFive(10)); // should display 23
Console.WriteLine(MultiplesOfThreeAndFive(49)); // should display 543
Console.WriteLine(MultiplesOfThreeAndFive(1000)); // should display 233168
Console.WriteLine(MultiplesOfThreeAndFive(8456)); // sholud display 16687353
Console.WriteLine(MultiplesOfThreeAndFive(19564)); // should display 89301183


int MultiplesOfThreeAndFive(int belowNumber)
{
    int sumMultiples = 0;

    for (int i = 1; i < belowNumber; i++)
    {
        if (i % 3 == 0 || i % 5 == 0)
        {
            sumMultiples += i;
        }
    }

    return sumMultiples;
}