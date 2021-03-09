using System;

/**
 * Name: Benton Le
 * Assignment: Lab 6 - Methods
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 03/9/2021
 * 
 * *** Question 4 ***
 * Write a method with the following specifications:
 * name: CalculateSumOfSquares
 * arguments: int representing the number of input that will constitute the sum
 * return value: int representing the sum of the squares of its input
 * displays: the user prompts but NOT the sum of the squares
 * tasks: prompt the user for inputs and accumulates the sum of the squares of the input. 
 * This is repeated as specified by the argument. Returns the final sum 
 * 
 * In your main when the user enters 4 in response to the menu choices, you will prompt the user for the number of inputs that she will be working with. 
 * You will invoke this method with this value and display the resulting value.
**/

namespace Question4
{
    class Question4
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
            for(int i = 0; i < input; i++)
            {
                Console.Write("Enter square to be calculated: ");
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
