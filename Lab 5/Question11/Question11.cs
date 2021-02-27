using System;

/**
 * Name: Benton Le
 * Assignment: Lab 5 - For, While Statements
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 02/23/2021
 * 
 * *** Question 11 ***
 * Print the decimal, octal, and hexadecimal values of all characters between the start and stop characters entered by a user. 
 * For example, if the user enters an a and a z, the program should print all the characters between a and z and their respective numerical values. 
 * Make sure that the second character entered by the user occurs later in the alphabet than the first character. 
 * If it does not, write a loop that repeatedly asks the user for a valid second character until one is entered.
 * Your output should be formatted as shown below
 * 
 * Letter  Decimal  Octal   Hex
 * a         97      141     61
 * b         98      142     62
 * c         99      143     63
 * d        100      144     64
 * e        101      145     65
 * 
 * to obtain an int from a char use an explicit cast
 * to obtain an octal from an int use Convert.ToString(«number_value», 8)
 * to obtain a hexadecimal from an int use Convert.ToString(«number_value», 16)
**/

namespace Question11
{
    class Question11
    {
        static void Main(String[] args)
        {
            Console.Write("Please enter starting letter: ");
            char endChar = ' ', startChar = Convert.ToChar(Console.ReadLine());

            while (startChar >= endChar)
            {
                Console.Write("Please enter ending letter: ");
                endChar = Convert.ToChar(Console.ReadLine());

                if (startChar >= endChar)
                {
                    Console.WriteLine("ERROR: Please enter a character greater then the starting character...");
                }
            }
            Console.WriteLine("Letter  Decimal  Octal   Hex");
            for (int i = (int)startChar; i <= (int)endChar; i++)
            {
                Console.WriteLine($"{(char)i, -4} { i, 7} { Convert.ToString(i, 8), 8} { Convert.ToString(i, 16).ToUpper(), 6}");
            }
        }
    }
}
