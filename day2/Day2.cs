using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2020_csharp.day2
{
    public class Day2
    {
        public void findValidPasswords()
        {
            string[] lines = File.ReadAllLines("../../../day2/passwords.txt");
            int total = 0;
            foreach (var line in lines)
            {
                string[] passwordDingen = line.Split(" ");
                string[] range = passwordDingen[0].Split("-");
                char letter = Convert.ToChar(passwordDingen[1].Replace(":", ""));
                string password = passwordDingen[2];
                int minValue = Int32.Parse(range[0]);
                int maxValue = Int32.Parse(range[1]);
                int count = password.Count(c => c == letter);
                total = count >= minValue && count <= maxValue ? total + 1 : total;
            }
            Console.WriteLine($"Total valid passwords: {total}");
        }
        
        public void findValidPasswords2()
        {
            string[] lines = File.ReadAllLines("../../../day2/passwords.txt");
            int total = 0;
            foreach (var line in lines)
            {
                string[] passwordDingen = line.Split(" ");
                string[] range = passwordDingen[0].Split("-");
                char letter = Convert.ToChar(passwordDingen[1].Replace(":", ""));
                string password = passwordDingen[2];
                int index1 = Int32.Parse(range[0]) - 1;
                int index2 = Int32.Parse(range[1]) - 1;
                total = (password[index1] == letter || password[index2] == letter) && password[index1] != password[index2] ? total + 1 : total;
            }
            Console.WriteLine($"Total valid passwords: {total}");
        }
    }
}