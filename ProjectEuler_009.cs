// Project Euler (https://projecteuler.net/) code exercises
// Taken from FreeCodeCamp (https://www.freecodecamp.org/learn/project-euler/) lesson plan
// Not coded in JavaScript, but C#
// Code by JT Stukes

// Problem 9 - Special Pythagorean triplet

/*
A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
a^2 + b^2 = c^2

For example, 3^2 + 4^2 = 9 + 16 = 25 = 52.

There exists exactly one Pythagorean triplet for which a + b + c = 1000. Find the product abc such that a + b + c = n.
*/

Console.WriteLine(SpecialPythagoreanTriplet(24)); // should write 480
Console.WriteLine(SpecialPythagoreanTriplet(120)); // should write 49920, 55080, or 60000
Console.WriteLine(SpecialPythagoreanTriplet(1000)); // should write 31875000

long SpecialPythagoreanTriplet(int goalSum)
{
    for (int i = 1; i <= goalSum; i++)
    {
        for (int j = 1; j <= goalSum; j++)
        {
            for (int k = 1; k <= goalSum; k++)
            {
                if (i < j && j < k)
                {
                    int a2 = i * i;
                    int b2 = j * j;
                    int c2 = k * k;

                    if (a2 + b2 == c2)
                    {
                        if (i + j + k == goalSum)
                        {
                            return i * j * k;
                        }
                    }
                }
            }

        }
    }
    return 0;
}