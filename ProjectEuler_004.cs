// Project Euler (https://projecteuler.net/) code exercises
// Taken from FreeCodeCamp (https://www.freecodecamp.org/learn/project-euler/) lesson plan
// Not coded in JavaScript, but C#
// Code by JT Stukes

// Problem 4 - Largest Palindrome Product

/*
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two n-digit numbers.
*/

Console.WriteLine(LargestPalindromeProduct(2)); // should print 9009
Console.WriteLine(LargestPalindromeProduct(3)); // should print 906609

long LargestPalindromeProduct(int orderOfMagnitude)
{
    long maxNumber = 1;
    for (int i = 0; i < orderOfMagnitude; i++)
    {
        maxNumber = maxNumber * 10;
    }
    maxNumber--;
    long minNumber = 1;
    for (int i = 0; i < orderOfMagnitude - 1; i++)
    {
        minNumber = minNumber * 10;
    }

    long largestPalindrome = 0;

    for (long i = maxNumber; i >= minNumber; i--)
    {
        for (long j = maxNumber; j >= minNumber; j--)
        {
            long productToCheck = i * j;

            if (productToCheck > largestPalindrome)
            {
                if (IsPalindrome(productToCheck))
                {
                    largestPalindrome = productToCheck;
                }
            }
        }
    }
    return largestPalindrome;
}

bool IsPalindrome(long answer)
{
    bool isPalindrome = true;
    char[] forwardCharArray = Convert.ToString(answer).ToCharArray();
    char[] reverseCharArray = new char[forwardCharArray.Length];

    for (int i = 0; i < forwardCharArray.Length; i++)
    {
        reverseCharArray[i] = forwardCharArray[forwardCharArray.Length - 1 - i];
    }

    for (int i = 0; i < forwardCharArray.Length; i++)
    {
        if (forwardCharArray[i] != reverseCharArray[i])
        {
            isPalindrome = false;
        }
    }
    return isPalindrome;
}
