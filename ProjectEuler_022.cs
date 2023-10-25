// Project Euler (https://projecteuler.net/) code exercises
// Taken from FreeCodeCamp (https://www.freecodecamp.org/learn/project-euler/) lesson plan
// Not coded in JavaScript, but C#
// Code by JT Stukes

// Problem 21 - Names Scores

/*
Using names, an array defined in the background containing over five-thousand first names, begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.

For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN would obtain a score of 938 × 53 = 49714.

What is the total of all the name scores in the array?
*/

string[] test1 = { "this", "is", "only", "a", "test" };
string[] test2 = { "i", "repeat", "this", "is", "only", "a", "test" };


Console.WriteLine(NamesScores(test1)); // should return 791
Console.WriteLine(NamesScores(test2)); // should return 1468

// creating string[] names array

string readText = File.ReadAllText("./0022/0022_names.txt"); // may have to change to backslash in Windows environments??
readText = readText.ToLower();
string[] delimStrings = {"\"", ","};
string[] names = readText.Split(delimStrings, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine(NamesScores(names)); // should return 871198282

long NamesScores(string[] listOfNames)
{
    // ascii char =>  a = 97 ... z = 122
    // just using built in array sort method
    string[] listOfNamesSorted = listOfNames;
    Array.Sort(listOfNamesSorted);

    long totalScore = 0;

    for (int i = 0; i < listOfNamesSorted.Length; i++)
    {
        int nameScore = 0;
        for (int j = 0; j < listOfNamesSorted[i].Length; j++)
        {
            char letter = listOfNamesSorted[i][j];
            nameScore += (letter - 96); // using ACSII lc numerical values
        }

        totalScore += nameScore * (i + 1);
    }

    return totalScore;
}