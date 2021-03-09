using System;

/**
 * Name: Benton Le
 * Assignment: Lab 6 - Methods
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 03/9/2021
 * 
 * *** Question 5 ***
 * Write a method with the following specifications:
 * name: CalculateSumOfCubes
 * arguments: none
 * return value: int representing the sum of the cubes of its input
 * displays: the user prompts but NOT the sum of the cubes
 * tasks: 
 * - prompt the user for the number of inputs that she will be working with
 * - read in the user input
 * - Prompts the user for their input
 * - Accumulates the sum of the cubes input
 * - Repeat the above two steps are many times as required
 * - Returns the final sum
 * 
 * In your main when the user enters 5 in response to the menu choices, you will invoke this method and display the resulting value
**/

namespace Question5
{
    class Question5
    {
        static void Main(String[] args)
        {
            DisplayMenu();
        }
        static int CalculateSum(int input)
        {
            int sum = 0;
            for (int i = 0; i < input; i++)
            {
                Console.Write("Enter number to be calculated: ");
                sum += Convert.ToInt32(Console.ReadLine());
            }
            return sum;
        }
        static int CalculateSumOfSquares(int input)
        {
            int sum = 0;
            for (int i = 0; i < input; i++)
            {
                Console.Write("Enter square to be calculated: ");
                sum += Convert.ToInt32(Console.ReadLine());
            }

            return sum;
        }
        static int CalculateSumOfCubes()
        {
            Console.Write("Please enter amount of cubes to be summed: ");
            int input = Convert.ToInt32(Console.ReadLine()), sum = 0;
            for (int i = 0; i < input; i++)
            {
                Console.Write("Please enter number: ");
                sum += Convert.ToInt32(Console.ReadLine());
            }

            return sum;
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
                            Console.Write("Please enter the amount of numbers you wish to calculate sum of: ");
                            Console.WriteLine($"Sum is: {CalculateSum(Convert.ToInt32(Console.ReadLine()))}\n");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Please enter the amount of numbers, to calculate sum of square: ");
                            Console.WriteLine($"Sum of squares is: {CalculateSumOfSquares(Convert.ToInt32(Console.ReadLine()))}\n");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine($"Sum of cubes is: {CalculateSumOfCubes()}\n");
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
