using System;

/**
 * Name: Benton Le
 * Assignment: Lab 4 - Do While Statements
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 02/16/2021
 * 
 * *** Question 8 ***
 * Same as the previous question but additionally displays the average of the numbers when the loop terminates. 
 * You will need a counter but not as a loop terminat
 * 
**/
namespace Question8
{
    class Question8
    {
        static void Main(String[] args)
        {
            double total = 0;
            int counter = 0;

            do
            {
                Console.Write("Enter a number: ");
                total += Convert.ToDouble(Console.ReadLine());
                counter++;
            } while (total < 100);

            Console.WriteLine($"Sum of numbers: {total}, Average of numbers: {total} / {counter} = {total / counter}");
        }
    }
}
