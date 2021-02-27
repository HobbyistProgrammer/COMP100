using System;

/**
 * Name: Benton Le
 * Assignment: Lab 3
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 02/9/2021
 * 
 * *** Question 5 ***
 * Write a program that prompts the user for a day of the week. 
 * The program will display a message based on the following table.
 * 
 * -----------------------
 * | Choice   | Message  |
 * | Sun      | "Home"   |
 * | Mon      | "Work"   |
 * | Tue      | "Work"   |
 * | Wed      | "Home"   |
 * | Thu      | "Work"   |
 * | Fri      | "Work"   |
 * | Sat      | "Work"   |
 * -----------------------
 * 
**/

namespace Question5
{
    class Question5
    {
        static void Main(String[] args)
        {
            Console.WriteLine("-----------------------\n" +
                              "| Choice   | Message  |\n" +
                              "| Sun      | Home     |\n" +
                              "| Mon      | Work     |\n" +
                              "| Tue      | Work     |\n" +
                              "| Wed      | Home     |\n" +
                              "| Thu      | Work     |\n" +
                              "| Fri      | Work     |\n" +
                              "| Sat      | Work     |\n" +
                              "-----------------------");
            Console.Write("Please enter a day of the week: ");
            string day = Console.ReadLine().ToLower();
            
            switch (day)
            {
                case "sun": case "wed":
                    Console.WriteLine("Home");
                    break;
                case "mon": case "tue": case "thu": case "fri": case "sat":
                    Console.WriteLine("Work");
                    break;
            }
        }
    }
}
