using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Exercise_02_Answers
{
    internal class Utility
    {
        public static Random rng = new Random();
        public static List<string> colors = new List<string>() { "dark red", "red", "light red", "dark orange", "orange", "light orange", "dark yellow", "yellow", "light yellow", "dark green", "green", "light green", "dark blue", "blue", "light blue", "dark indigo", "indigo", "light indigo", "dark violet", "violet", "light violet", };


        public static string RandomString(int length) // Thank you StackOverflow
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[rng.Next(s.Length)]).ToArray());
        }
        public static List<int> RandomNumberCollection(int count)
        {
            var list = Enumerable.Range(1, rng.Next(count)).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = rng.Next(count);
            }
            return list;
        }
        public static List<string> RandomColorsList() // Values must be within range of Int.32
        {
            List<string> list = new List<string>();

            for (int i = 0; i < colors.Count; i++)
            {
                list.Add(colors[rng.Next(0, colors.Count)]);
            }
            
            return list;
        }
        public static string[] RandomColorsArray(int minValue, int maxValue)
        {
            string[] colors = RandomlySizedArray(minValue, maxValue);
            for (int i = 0; i < colors.Length; i++)
            {
                var color = Utility.colors[rng.Next(0, Utility.colors.Count)];
                colors[i] = color;
            }
            return colors;
        }

        public static void AddSpaces(int numberOfSpaces)
        {
            while (numberOfSpaces > 0)
            {
                Console.WriteLine();
                numberOfSpaces--;
            }
        }
        public static string[] RandomlySizedArray(int minValue, int maxValue) // Values must be within range of Int.32
        {
            var size = rng.Next(minValue, maxValue);
            return new string[size];
        }
    }
}
