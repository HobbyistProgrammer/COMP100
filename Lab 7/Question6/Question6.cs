using System;

/**
 * Name: Benton Le
 * Assignment: Lab 7 - Arrays
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 03/9/2021
 * 
 * *** Question 6 ***
 * In your main method use the method in question 2 to display the numbers array, 
 * then use the Array.Binarysearch() method to try to find the position of 3 in the numbers array.
 * 
 * What is your answer?
 * Now repeat the same steps after you have sorted the array and printed the sorted array
 * 
**/

namespace Question6
{
    class Question6
    {
        static void Main(String[] args)
        {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 };
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();

            foreach(int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            int foundNumber = Array.BinarySearch(numbers, 3);
            // The position of 3 is -9 because the array is unsorted, therefore an incorrect and negative number could be returned.
            Console.WriteLine($"Unsorted array found 3 at position {foundNumber}\n");

            Array.Sort(numbers);
            foreach(int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            foundNumber = Array.BinarySearch(numbers, 3);
            Console.WriteLine($"Sorted array found 3 at position {foundNumber}\n");

           
        }
    }
}
