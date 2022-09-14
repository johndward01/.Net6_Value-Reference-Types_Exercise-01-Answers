using System;
using System.Collections.Generic;

namespace Methods_Exercise_02_Answers
{
    internal class Program
    {
        public static void SampleMethod()
        {
            // method logic 
        }

        static void Main(string[] args)
        {
            #region EXAMPLES of printing out each field on a single line with spaces in-between
            var _list1 = Utility.RandomColorsList();
            var _arr1 = Utility.RandomColorsArray(1, 11);
            var _str1 = Utility.RandomString(50);
            var _numbers = Utility.RandomNumberCollection(50);

            //// Example 1:
            //foreach (var item in _list1)
            //{
            //    Console.Write($"{item} ");
            //}
            //Utility.AddSpaces(2);

            ////Example 2:
            //foreach (var item in _arr1)
            //{
            //    Console.Write($"{item} ");
            //}
            //Utility.AddSpaces(2);

            //// Example 3:
            //foreach (var item in _str1)
            //{
            //    Console.Write(item);
            //}
            //Utility.AddSpaces(2);

            //// Example 4:
            //foreach (var item in _numbers)
            //{
            //    Console.Write(item);
            //}
            //Utility.AddSpaces(2);

            #endregion

            // TODO: Call each of the methods you created below here

            Console.WriteLine("PRINT LIST");
            Console.WriteLine("===========================");
            PrintList(_list1);
            Utility.AddSpaces(3);

            Console.WriteLine("FOUND BLUE");
            Console.WriteLine("===========================");
            FoundBlue(_arr1);
            Utility.AddSpaces(3);

            Console.WriteLine("REMOVE VOWELS");
            Console.WriteLine("===========================");
            RemoveVowels(_str1);
            Utility.AddSpaces(3);

            Console.WriteLine("REMOVE EVENS");
            Console.WriteLine("===========================");
            RemoveEvens(_numbers);
            Utility.AddSpaces(3);
        }

        // TODO: Create a method that takes the collection below and iterates through it printing out each item to the console
        public static void PrintList(List<string> list)
        {
            foreach (var str in list)
            {
                Console.WriteLine(str);
            }
        }

        // TODO: Create a method that takes the array below and prints out Found it! if there is the string "blue" inside of it
        public static void FoundBlue(string[] arr)
        {
            bool foundIt = false;

            foreach (var str in arr)
            {
                if (str == "blue")
                {
                    foundIt = true;
                }
            }

            if (foundIt == true)
            {
                Console.WriteLine("Found it!");
            }
            else
            {
                Console.WriteLine("Didn't find it!");
            }
        }


        // TODO: Create a method that removes all of the vowels from the string below
        public static void RemoveVowels(string str)
        {
            string newStr = "";
            foreach (var letter in str)
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    continue;
                }
                newStr += letter;
            }
            Console.WriteLine(newStr);
        }

        // TODO: Create a method that removes all of the even numbers
        public static void RemoveEvens(IEnumerable<int> nums)
        {
            var odds = new List<int>();
            foreach (var num in nums)
            {
                if (num % 2 != 0)
                {
                    odds.Add(num);
                }
            }
            odds.ForEach(num => Console.WriteLine(num));
        }
    }
}
