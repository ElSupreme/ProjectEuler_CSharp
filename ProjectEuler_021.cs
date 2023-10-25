// Project Euler (https://projecteuler.net/) code exercises
// Taken from FreeCodeCamp (https://www.freecodecamp.org/learn/project-euler/) lesson plan
// Not coded in JavaScript, but C#
// Code by JT Stukes

// Problem 21 - Amicable Numbers

/*
Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).

If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.

For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.

Evaluate the sum of all the amicable numbers under n.
*/

Console.WriteLine(SumAmicableNum(1000)); // sholud write 504
Console.WriteLine(SumAmicableNum(2000)); // sholud write 2898
Console.WriteLine(SumAmicableNum(5000)); // sholud write 8442
Console.WriteLine(SumAmicableNum(10000)); // sholud write 31626

int SumAmicableNum(int underNumber)
{
    int[] sumOfDivisors = new int[underNumber + 1];

    // find all sum of divisors
    for (int i = 1; i <= underNumber; i++)
    {
        int divisorSum = 0;
        for (int j = 1; j <= underNumber; j++)
        {
            if (i % j == 0)
            {
                divisorSum += j;
            }
        }
        sumOfDivisors[i] = divisorSum - (i);
    }

    // find pairs and sum
    int sumOfAmicable = 0;
    for (int i = 1; i < sumOfDivisors.Length; i++)
    {
        for (int j = 1; j < sumOfDivisors.Length; j++)
        {
            if (i == sumOfDivisors[j] && j == sumOfDivisors[i] && i != j)
            {
                sumOfAmicable += i;
            }

        }
    }

    return sumOfAmicable;
}