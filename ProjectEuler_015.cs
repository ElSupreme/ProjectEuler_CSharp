// Project Euler (https://projecteuler.net/) code exercises
// Taken from FreeCodeCamp (https://www.freecodecamp.org/learn/project-euler/) lesson plan
// Not coded in JavaScript, but C#
// Code by JT Stukes

// Problem 15 - Lattice paths

/*
Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
a diagram of 6 2 by 2 grids showing all the routes to the bottom right corner

How many such routes are there through a given gridSize?
*/

// a 2x2 lattice has 3 nodes in x and y
// long routeCount = 0;

Console.WriteLine(LatticePaths(4)); // should write 70
Console.WriteLine(LatticePaths(9)); // should write 48620
Console.WriteLine(LatticePaths(20)); // should write 137846528820



// First solution brute force tracing takes too long
/*

long LatticePaths(int gridSize)
{
    routeCount = 0;
    TraceLatticePaths(gridSize, 0, 0);
    return routeCount;
}

void TraceLatticePaths(int gridSize, int xPosition, int yPosition)
{

    if (xPosition == gridSize && yPosition == gridSize)
    {
        routeCount++;
        return;
    }

    // move along x
    if (xPosition < gridSize)
    {
        TraceLatticePaths(gridSize, xPosition + 1, yPosition);
    }

    // move along y
    if (yPosition < gridSize)
    {
        TraceLatticePaths(gridSize, xPosition, yPosition + 1);
    }
}
*/

// Working to come up with algorithm

// Paths = previous paths * (4 - (2/gridsize))
// Not quite sure why yet (previous paths * 4) because 4 grids one smaller fit inside
// the 2/gridsize is not quite clear
// for 2x2 in 3x3 it makes sense there is -1 but fro larger ???

long LatticePaths(int gridSize)
{
    decimal pathCount = 2; // for 1x1 grid

    for (decimal i = 2; i <= gridSize; i++)
    {
        pathCount = pathCount * (4 - (2/i));
    }

    return Convert.ToInt64(pathCount);
}
