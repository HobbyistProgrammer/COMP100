using System;

/**
 * Name: Benton Le
 * Assignment: Lab 7 - Arrays
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 03/9/2021
 * 
 * *** Question 5 ***
 * In your main method use the method in question 3 to display the poem array, 
 * then use the Array.Sort() method to sort the poem array and then again call the appropriate methodto print it
 * 
**/

namespace Question5
{
    class Question5
    {
        static void Main(String[] args)
        {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 };
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();

            foreach(string word in poem)
            {
                Console.Write($"{word} ");
            }
            Console.WriteLine();
            Array.Sort(poem);
            foreach(string word in poem)
            {
                Console.Write($"{word} ");
            }
            Console.WriteLine();
        }
    }
}
