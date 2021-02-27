using System;

/**
 * Name: Benton Le
 * Assignment: Lab 4 - Do While Statements
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 02/16/2021
 * 
 * *** Question 7 ***
 * To repeatedly prompt for a number and sum it. When the sum just exceeds 100, stop the prompting and display the sum at the end. 
 * You must not display the sum while the user in typing in numbers. 
 * (You do not need a counter but you will need some way of terminating theloop
 * 
**/

namespace Lab_4
{
    class Question7
    {
        static void Main(String[] args)
        {
            double total = 0;

            do
            {
                Console.Write("Enter a number: ");
                total += Convert.ToDouble(Console.ReadLine());
            } while (total < 100);

            Console.WriteLine($"Sum of numbers: {total}");
        }
    }
}
