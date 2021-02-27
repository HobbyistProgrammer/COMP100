using System;

/**
 * Name: Benton Le
 * Assignment: Lab 3
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 02/9/2021
 * 
 * *** Question 3 ***
 * Write a program that allows the user to enter two integers and a character 
 * If the character is A, add the two integers 
 * If it is S, subtract the second integer from the first else multiply the integers 
 * Display the results of the arithmet
**/
namespace Lab3
{
    class Question3
    {
        static void Main(String[] args)
        {
            int first, second;
            char userChar;

            Console.Write("Please enter the first integer: ");
            first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the second integer: ");
            second = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the character (A/S): ");
            userChar = Convert.ToChar(Console.ReadLine());
            
            // This code works as a ToUpper() for chars.
            if(userChar == 'a' || userChar == 's')
                userChar = (char)(userChar - 32);

            switch(userChar){
                case 'A':
                    Console.WriteLine($"{first} + {second} = {first + second}");
                    break;
                case 'S':
                    Console.WriteLine($"{first} - {second} = {first - second}");
                    break;
                default:
                    Console.WriteLine($"{first} * {second} = {first * second}");
                    break;
            }
        }
    }
}
