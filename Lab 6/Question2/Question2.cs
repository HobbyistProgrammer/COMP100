using System;

/**
 * Name: Benton Le
 * Assignment: Lab 6 - Methods
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 03/9/2021
 * 
 * *** Question 2 ***
 * Modify your main so that the above method is call repeatedly.
 * The program will terminate when the user enters 0. 
 * Any otherchoice should produce an error message. 
 * Because you will not be doing any arithmetic you may accept the user response either as an int, or a char or a string.
**/

namespace Question2
{
    class Question2
    {
        static void Main (String[] args)
        {
            DisplayMenu();
        }
        static void DisplayMenu()
        {
            int menuChoice = 0;
            do
            {
                Console.Write("Calculation Menu\n" +
                              "3) Calculate Sum\n" +
                              "4) Calculate Sum of Squares\n" +
                              "5) Calculate Sum of Cubes\n" +
                              "0) To Exit\n" +
                              "\nEnter the number that corresponds to your choice: ");
                menuChoice = Convert.ToInt32(Console.ReadLine());
                switch (menuChoice)
                {
                    case 3:
                        {
                            Console.WriteLine("Coming soon!...\n");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Coming soon!...\n");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Coming soon!...\n");
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Goodbye!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("ERROR: Please enter a valid choice...\n");
                            break;
                        }

                }
            } while (menuChoice != 0);
        }
    }
}
