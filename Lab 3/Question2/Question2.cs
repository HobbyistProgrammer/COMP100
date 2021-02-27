using System;

/**
 * Name: Benton Le
 * Assignment: Lab 3
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 02/9/2021
 * 
 * *** Question 2 ***
 * Write a program that prompts the user for a menu choice. 
 * The program will display a message based on the following table:
 * 
 * -------------------------------------------------------
 * | Choice                 | Message                    |
 * | 1                      | "Calculate area"           |
 * | 2                      | "Calculate volume"         |
 * | 3                      | "Calculate surface area"   |
 * | 0                      | "Exit the program"         |
 * | << any other input >>  | "ERROR: Invalid choice"    |
 * -------------------------------------------------------
 * 
**/

namespace Question2
{
    class Question2
    {
        static void Main(String[] args)
        {
            Console.WriteLine("-------------------------------------------------------\n" +
                              "| Choice                 | Message                    |\n" +
                              "| 1                      | Calculate area             |\n" +
                              "| 2                      | Calculate volume           |\n" +
                              "| 3                      | Calculate surface area     |\n" +
                              "| 0                      | Exit the program           |\n" +
                              "| << any other input >>  | ERROR: Invalid choice      |\n" +
                              "-------------------------------------------------------");
            Console.Write("Please enter menu choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            string message;
            switch (choice)
            {
                case 1:
                    message = "Calculate area";
                    break;
                case 2:
                    message = "Calculate volume";
                    break;
                case 3:
                    message = "Calculate surface area";
                    break;
                case 0:
                    message = "Exit the program";
                    break;
                default:
                    message = "ERROR: Invalid Choice";
                    break;
            }
            Console.WriteLine($"You chose: {message}");
        }
    }
}
