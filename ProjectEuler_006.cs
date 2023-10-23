// Project Euler (https://projecteuler.net/) code exercises
// Taken from FreeCodeCamp (https://www.freecodecamp.org/learn/project-euler/) lesson plan
// Not coded in JavaScript, but C#
// Code by JT Stukes

// Problem 6 - Sum square difference

/*


The sum of the squares of the first ten natural numbers is,
1^2 + 2^2 + ... + 10^2 = 385

The square of the sum of the first ten natural numbers is,
(1 + 2 + ... + 10)^2 = 552 = 3025

Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

Find the difference between the sum of the squares of the first n natural numbers and the square of the sum.
*/

Console.WriteLine(SumSquareDifference(10)); // sholud write 2640
Console.WriteLine(SumSquareDifference(20)); // sholud write 41230
Console.WriteLine(SumSquareDifference(100)); // sholud write 25164150

long SumSquareDifference(int upToNumber)
{
    long sumOfSquares = 0;
    long sumsBeforeSquare = 0;
    long squareOfsums = 0;

    for (int i = 1; i <= upToNumber; i++)
    {
        sumOfSquares += (i * i);
        sumsBeforeSquare += i; 
    }
    squareOfsums = (sumsBeforeSquare * sumsBeforeSquare);
    return (squareOfsums - sumOfSquares);
}
