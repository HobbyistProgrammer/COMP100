using System;

/**
 * Name: Benton Le
 * Assignment: Lab 5 - For, While Statements
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 02/23/2021
 * 
 * *** Question 7 ***
 * Write a program to produce a table of numbers from 10 to 1, with their squares and cubes.
 * Again, your table must look professiona
 * 
**/


namespace Lab_5
{
    class Question7
    {
        static void Main(String[] args)
        {
            Console.WriteLine("-------------------------------\n" +
                              "| Number  | Squared  | Cubed  |\n" +
                              "|-----------------------------|");

            for (int i = 1; i <= 10; i++)
            {
                int squared = 0, cubed = 0;
                squared = i * i;
                cubed = i * i * i;

                Console.WriteLine($"|{i, 8} | {squared, 8} | {cubed, 6} |");
            }
            Console.WriteLine("-------------------------------");
        }
    }
}
