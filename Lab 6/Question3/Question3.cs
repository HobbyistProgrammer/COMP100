using System;

/**
 * Name: Benton Le
 * Assignment: Lab 6 - Methods
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 03/9/2021
 * 
 * *** Question 3 ***
 * Write a method with the following specifications:
 * name: CalculateSum
 * arguments: a single int representing the number of inputs that will constitute the sum
 * return value: int representing the sum of all the user inputs
 * displays: only the prompt for the user inputs, but does not display the sum 
 * tasks: prompt and accepts inputs (as many as specified by the argument), and sum them, 
 * Finally the method will return the sum of all the inputs (the sum) 
 * 
 * In your main you will call this method when the user enters 3 in response to the menu choices. 
 * You will invoke this method with argument 5 and then display the resulting value from the method.
**/

namespace Question3
{
    class Question3
    {
        static void Main(String[] args)
        {
            DisplayMenu();
        }
        static int CalculateSum(int input)
        {
            int sum = 0;
            for(int i = 0; i < input; i++)
            {
                Console.Write("Enter number to be calculated: ");
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
