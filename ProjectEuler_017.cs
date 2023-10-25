// Project Euler (https://projecteuler.net/) code exercises
// Taken from FreeCodeCamp (https://www.freecodecamp.org/learn/project-euler/) lesson plan
// Not coded in JavaScript, but C#
// Code by JT Stukes

// Problem 17 - Number Letter Counts

/*
If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.

If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?

NOTE: Do not count spaces or hyphens. For example, 346 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.
*/

Console.WriteLine(NumberLetterCounts(5)); // should write 19
Console.WriteLine(NumberLetterCounts(150)); // should write 1903
Console.WriteLine(NumberLetterCounts(1000)); // should write 21124


string andString = "";

int NumberLetterCounts(int countTo)
{
    string wordSmash = "";

    for (int i = 1; i <= countTo; i++)
    {
        if (i < 1000)
        {
            andString = "and";
        }
        else
        {
            andString = "";
        }

        switch (i)
        {
            // ones and tens (1-99)
            case <= 99:
                wordSmash = wordSmash + WriteTens(i);
                break;

            // hundreds (100 - 999)
            case <= 999:
                wordSmash = wordSmash + WriteHundreds(i);
                break;

            // thousands (1000 - 999,999)
            case <= 999999:
                wordSmash = wordSmash + WriteThousands(i);
                break;

            // millions (1,000,000 - 999,999,999)
            case <= 999999999:
                //wordSmash = wordSmash + WriteMillions(i);
                break;

            default:
                Console.WriteLine("Failure: Default in NumberLetterCounts()");
                //wordSmash = "";
                break;
        }
    }
    //Console.WriteLine(wordSmash);
    return wordSmash.Length;
}

string WriteOnes(int number)
{
    switch (number)
    {
        case 0:
            return "";
            break;
        case 1:
            return "one";
            break;
        case 2:
            return "two";
            break;
        case 3:
            return "three";
            break;
        case 4:
            return "four";
            break;
        case 5:
            return "five";
            break;
        case 6:
            return "six";
            break;
        case 7:
            return "seven";
            break;
        case 8:
            return "eight";
            break;
        case 9:
            return "nine";
            break;
        default:
            Console.WriteLine("Failure: Default in WriteOnes()");
            return "";
            break;
    }
}

string WriteTens(int number)
{
    switch (number)
    {
        case <= 9:
            return WriteOnes(number);
            break;
        case 10:
            return "ten";
            break;
        case 11:
            return "eleven";
            break;
        case 12:
            return "twelve";
            break;
        case 13:
            return "thirteen";
            break;
        case 14:
            return "fourteen";
            break;
        case 15:
            return "fifteen";
            break;
        case 16:
            return "sixteen";
            break;
        case 17:
            return "seventeen";
            break;
        case 18:
            return "eighteen";
            break;
        case 19:
            return "nineteen";
            break;
        case <= 29:
            return "twenty" + WriteOnes(number % 10);
            break;
        case <= 39:
            return "thirty" + WriteOnes(number % 10);
            break;
        case <= 49:
            return "forty" + WriteOnes(number % 10);
            break;
        case <= 59:
            return "fifty" + WriteOnes(number % 10);
            break;
        case <= 69:
            return "sixty" + WriteOnes(number % 10);
            break;
        case <= 79:
            return "seventy" + WriteOnes(number % 10);
            break;
        case <= 89:
            return "eighty" + WriteOnes(number % 10);
            break;
        case <= 99:
            return "ninety" + WriteOnes(number % 10);
            break;
        default:
            Console.WriteLine("Failure: Default in WriteTens()");
            return "";
            break;
    }
}

string WriteHundreds(int number)
{
    if (number / 100 < 1)
    {
        return WriteTens(number);
    }

    if (number % 100 == 0)
    {
        return WriteOnes(number / 100) + "hundred";
    }
    else
    {
        return WriteOnes(number / 100) + "hundred" + andString + WriteTens(number % 100);

    }
}

string WriteThousands(int number)
{
    if (number / 1000 < 1)
    {
        Console.WriteLine("Failue: Default in WriteThousands()");
        return "";
    }
    else if (number % 1000 == 0)
    {
        return WriteHundreds(number / 1000) + "thousand";
    }
    else
    {
        return WriteHundreds(number / 1000) + "thousand" + WriteHundreds(number % 1000);
    }
}