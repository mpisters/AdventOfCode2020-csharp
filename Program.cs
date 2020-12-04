using System;
using AdventOfCode2020_csharp.day1;

namespace AdventOfCode2020_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Day1 day1 = new Day1();
            day1.find2020();
            day1.find2020With3Entries();
        }
    }
}