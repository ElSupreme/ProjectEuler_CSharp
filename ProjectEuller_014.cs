// Project Euler (https://projecteuler.net/) code exercises
// Taken from FreeCodeCamp (https://www.freecodecamp.org/learn/project-euler/) lesson plan
// Not coded in JavaScript, but C#
// Code by JT Stukes

// Problem 14 - Longest Colatz Sequence

/*
The following iterative sequence is defined for the set of positive integers:
n → n/2 (n is even)
n → 3n + 1 (n is odd)

Using the rule above and starting with 13, we generate the following sequence:
13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1

It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

Which starting number, under the given limit, produces the longest chain?

Note: Once the chain starts the terms are allowed to go above limit.
*/

//

Console.WriteLine(LongestCollatzSequence(14)); // should write 9
Console.WriteLine(LongestCollatzSequence(5847)); // should write 3711
Console.WriteLine(LongestCollatzSequence(46500)); // should write 35655
Console.WriteLine(LongestCollatzSequence(54512)); // should write 52527
Console.WriteLine(LongestCollatzSequence(100000)); // should write 77031
Console.WriteLine(LongestCollatzSequence(1000000)); // should write 837799

int LongestCollatzSequence(int startingNumber)
{
    // creating an array wich each position representing the starting number
    int[] allCollatz = new int[startingNumber + 1];

    for (int i = 1; i <= startingNumber; i++)
    {
        int currentCount = 0;
        long collatzValue = i;
        while (collatzValue != 1)
        {
            currentCount++;
            if (collatzValue % 2 ==0)
            {
                collatzValue = collatzValue / 2;
            }
            else
            {
                collatzValue = (3 * collatzValue) + 1;
            }
            if (collatzValue < i) // check for existing Collatz calculation and add steps
            {
                currentCount += allCollatz[collatzValue];
                collatzValue = 1;
            }
            //Console.Write($" {collatzValue}");
        }
       // Console.WriteLine($" count = {currentCount}");
        allCollatz[i] = currentCount;
    }

    int maxSteps = allCollatz.Max();
    return Array.IndexOf(allCollatz, maxSteps);
}