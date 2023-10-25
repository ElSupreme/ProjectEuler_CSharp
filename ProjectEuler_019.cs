// Project Euler (https://projecteuler.net/) code exercises
// Taken from FreeCodeCamp (https://www.freecodecamp.org/learn/project-euler/) lesson plan
// Not coded in JavaScript, but C#
// Code by JT Stukes

// Problem 19 - Counting Sundays

/*
You are given the following information, but you may prefer to do some research for yourself.

    1 Jan 1900 was a Monday.
    Thirty days has September,
    April, June and November.
    All the rest have thirty-one,
    Saving February alone,
    Which has twenty-eight, rain or shine.
    And on leap years, twenty-nine.
    A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.

How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
*/

// My solution only works from Jan 1, 1901 onward

Console.WriteLine(CountingSundays(1943, 1946)); // should write 6
Console.WriteLine(CountingSundays(1995, 2000)); // should write 10
Console.WriteLine(CountingSundays(1901, 2000)); // should write 171

// (lastYear - firstYear) * (12.0 / 7.0) = result
// ;-)

int CountingSundays(int firstYear, int lastYear)
{
    // first we calculate the number of days per year
    // this allows us to find the first day of each year
    int calendarLength = lastYear - 1900;
    int totalDaysToLastYear = 0;
    int totalSundayFirstDays = 0;
    int[] daysInYear = new int[calendarLength + 1];
    int[] monthStartDaysNormal = { 0, 31, 60, 91, 121, 152, 182, 213, 244, 274, 305, 335 };
    int[] monthStartDaysLeap = { 0, 31, 61, 92, 122, 153, 183, 214, 245, 275, 306, 336 };
    bool leapYear = false;

    for (int year = 1900; year <= lastYear; year++)
    {
        if (year % 4 == 0 && year % 100 != 0)
        {
            totalDaysToLastYear += 366;
            daysInYear[year - 1900] = totalDaysToLastYear;
            leapYear = true;

            totalSundayFirstDays += DaysStartingWithSunday(year, leapYear);
        }
        else if (year % 400 == 0)
        {
            totalDaysToLastYear += 366;
            daysInYear[year - 1900] = totalDaysToLastYear;
            leapYear = true;

            totalSundayFirstDays += DaysStartingWithSunday(year, leapYear);

        }
        else
        {
            totalDaysToLastYear += 365;
            daysInYear[year - 1900] = totalDaysToLastYear;
            leapYear = false;

            totalSundayFirstDays += DaysStartingWithSunday(year, leapYear);

        }
    }

    // summing all days prior to 'firstYear' and determining the start day
    // 0 -> Sunday; 6 -> Saturday
    int DaysStartingWithSunday(int year, bool leapYear)
    {
        int daysStartingSundayCounter = 0;
        int[] monthStartDays = monthStartDaysNormal;
        if (leapYear)
        {
            monthStartDays = monthStartDaysLeap;
        }

        for (int month = 0; month < monthStartDays.Length; month++)
        {
            if ((daysInYear[year - 1900] + monthStartDays[month]) % 7 == 0 && year >= firstYear && year < lastYear)
            {
                daysStartingSundayCounter++;
            }
        }

        return daysStartingSundayCounter;
    }

    return totalSundayFirstDays;
}

