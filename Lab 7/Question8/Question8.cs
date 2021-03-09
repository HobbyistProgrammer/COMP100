using System;

/**
 * Name: Benton Le
 * Assignment: Lab 7 - Arrays
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 03/9/2021
 * 
 * *** Question 8 ***
 * Write another method that creates and return an array of ints. 
 * The method takes a single argument that represents the number of items in the resulting array and does the following:
 * - Declare an array of the required type.
 * - Allocate memory for the intended number of items.
 * - Using any looping structure, assign to each element a random integer in the range 100 to 200.
 * - Return the array.
 * You will need the following statement in global scope.
 * static Random rand = newRandom();
 * The following statement will give you a random letterrand.Next(100, 200);
 * Exercise this method in a similar fashion as you did for question 7
**/

namespace Question8
{
    class Question8
    {
        static Random rand = new Random();

        static void Main(String[] args)
        {
            int[] createdArray = CreateArray(10);
            Console.WriteLine("Numbers in arrays: ");

            foreach(int number in createdArray)
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
                newArray[i] = rand.Next(100, 200);
            }

            return newArray;
        }
    }
}
