using System;

/**
 * Name: Benton Le
 * Assignment: Lab 5 - For, While Statements
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 02/23/2021
 * 
 * *** Question 8 ***
 * Write a program that displays a conversion table from Fahrenheit to Celsius. 
 * The program must request the starting Fahrenheit value, the ending Fahrenheit value, and the increment. 
 * Thus, instead of the condition checking for a fixed count, the condition checks for the ending Fahrenheit value. 
 * Your table must look professional!
 * 
**/

namespace Question8
{
    class Question8
    {
        static void Main(String[] args)
        {
            Console.Write("Please enter starting fahrenheit value: ");
            double startValue = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter ending fahrenheit value: ");
            double endValue = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter increment value: ");
            double increment = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("--------------------------\n" +
                              "| Fahrenheit  | Celsius  |\n" +
                              "|-------------------------");
            while (startValue <= endValue)
            {
                double celsius = Math.Round(((startValue - 32) * 5) / 9);
                Console.WriteLine($"|{ startValue, 12} | {celsius, 8} |");

                startValue += increment;
            }
            Console.WriteLine("--------------------------");
        }
    }
}
