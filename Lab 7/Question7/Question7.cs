using System;

/**
 * Name: Benton Le
 * Assignment: Lab 7 - Arrays
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 03/9/2021
 * 
 * *** Question 7 ***
 * Write a method that creates and return an array of ints. 
 * The method takes a single int argument that represents the how many items will be in the resulting array and does the following:
 * - Declare an array of the required type.
 * - Allocate memory for the intended number of items.
 * - Using any looping structure, prompt the user for a number and then assign to each element. 
 * - Return the array after the loop.
 * In your main method do the following: 
 * (a) call this method (you will need to supply an argument), 
 * assign the resulting value to at suitable variable and then (b) display this variable
 * 
**/

namespace Question7
{
    class Question7
    {
        static void Main(String[] args)
        {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 };
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();

            int[] inputArray = CreateArray(5);
            Console.Write("Numbers in array: ");
            foreach(int number in inputArray)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
        static int[] CreateArray(int sizeOfArray)
        {
            int[] newArray = new int[sizeOfArray];

            for(int i = 0; i < sizeOfArray; i++)
            {
                Console.Write($"Input number for element {i}: ");
                newArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            return newArray;
        }
    }
}
