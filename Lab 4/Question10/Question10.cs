using System;

/**
 * Name: Benton Le
 * Assignment: Lab 4 - Do While Statements
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 02/16/2021
 * 
 * *** Question 10 ***
 * A conversion table of Celsius to Fahrenheit temperature. 
 * The table must start with 100 Celsius and end at 0 Celsius with decrements of 10. 
 * (Fahrenheit = 9/5 * Celsius + 32). 
 * Your table must have a suitable header and the values in the table must be right-align like the output of question 11.
 * 
**/

namespace Question10
{
    class Question10
    {
        static void Main(String[] args)
        {
            int celsius = 100;

           

            Console.WriteLine("-----------------------------------------\n" +
                              "| Temperature in C* | Temperature in F* |\n" +
                              "|---------------------------------------|");
            do
            {
                double fahrenheit = celsius * 9 / 5 + 32;

                Console.WriteLine(String.Format("|{0, 18} | {1, 17} |", celsius, fahrenheit));

                celsius--;
            } while (!(celsius < 0));

            Console.WriteLine("-----------------------------------------");
            
        }
    }
}
