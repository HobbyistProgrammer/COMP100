using System;

/**
 * Name: Benton Le
 * Assignment: Lab 6 - Methods
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 03/9/2021
 * 
 * *** Question 6 ***
 * Write a method with the following specifications:
 * name: CalculateAverage
 * arguments: none
 * return value: double representing the mathematical average of its inputs
 * displays: the user prompts but NOT the average
 * tasks: prompt and accept for the number of inputs that she will be working with. 
 * Prompts the user for the required number of inputs. 
 * Calculate and return the average of the inputs. 
 * 
 * Modify your DisplayMenu method by adding another choice below CalculateSumOfCubes. 
 * In your main when the user enters the appropriate choice in response to the menu choices, you will invoke this method and display the resulting value.
**/

namespace Question6
{
    class Question6
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
        static double CalculateAverage()
        {
            Console.Write("Please enter amount of numbers to be averaged: ");
            int input = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < input; i++)
            {
                Console.Write("Please enter number: ");
                sum += Convert.ToDouble(Console.ReadLine());
            }

            return sum / input;
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
                              "6) Calculate Average\n" +
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
                    case 6:
                        {
                            Console.WriteLine($"Average of numbers is: {CalculateAverage()}\n");
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
