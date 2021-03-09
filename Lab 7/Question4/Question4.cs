using System;

/**
 * Name: Benton Le
 * Assignment: Lab 7 - Arrays
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 03/9/2021
 * 
 * *** Question 4 ***
 * In your main method use the method in question 1 to display the letters array, 
 * then usethe Array.Reverse() method to reverse the letters array and then again call theappropriate method to print it
 * 
**/

namespace Question4
{
    class Question4
    {
        static void Main(String[] args)
        {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 }; 
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();

            foreach (char letter in letters)
            {
                Console.Write($"{letter}");
            }
            Console.WriteLine();
            Array.Reverse(letters);
            foreach (char letter in letters)
            {
                Console.Write($"{letter}");
            }
            Console.WriteLine();

        }
    }
}
