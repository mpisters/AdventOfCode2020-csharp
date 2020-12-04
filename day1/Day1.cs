using System;
using System.IO;

namespace AdventOfCode2020_csharp.day1
{
    public class Day1
    {
        public void find2020()
        {
            string[] lines = File.ReadAllLines("../../../day1/money.txt");
            foreach (var line in lines)
            {
                foreach (var line2 in lines)
                {
                    int number1 = Int32.Parse(line);
                    int number2 = Int32.Parse(line2);
                    if (number1 + number2 == 2020)
                    {
                        Console.WriteLine($"{number1 * number2}");
                        break;
                    }
                }
            }
        }

        public void find2020With3Entries()
        {
            string[] lines = File.ReadAllLines("../../../day1/money.txt");
            foreach (var line in lines)
            {
                foreach (var line2 in lines)
                {
                    foreach (var line3 in lines)
                    {
                        int number1 = Int32.Parse(line);
                        int number2 = Int32.Parse(line2);
                        int number3 = Int32.Parse(line3);
                        if (number1 + number2 + number3 == 2020)
                        {
                            Console.WriteLine($"{number1 * number2 * number3}");
                            break;
                        }
                    }
                }
            }
        }
    }
}