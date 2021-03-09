using System;

/**
 * Name: Benton Le
 * Assignment: Lab 6 - Methods
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 03/9/2021
 * 
 * *** Question 1 ***
 * Write a method with the following specifications:
 * name: DisplayMenu
 * arguments: none
 * return value: none
 * 
 * tasks: display the following menu choice on the screen
 * 
 * Calculation Menu
 * 3) Calculate Sum 
 * 4) Calculate Sum of Squares
 * 5) Calculate Sum of Cubes
 * 0) To Exit
 * 
 * Enter the number that corresponds to your choice: 
 * 
 * You may beautify the output to your own likings. 
 * You don’t have to implement the functionalities of the various menu choices at this stageCall this method from your main
 * 
**/


namespace Lab6
{
    class Question1
    {
        static void Main(String[] args)
        {
            DisplayMenu();
        }

        static void DisplayMenu()
        {
            Console.Write("Calculation Menu\n" +
                              "3) Calculate Sum\n" +
                              "4) Calculate Sum of Squares\n" +
                              "5) Calculate Sum of Cubes\n" +
                              "0) To Exit\n" +
                              "\nEnter the number that corresponds to your choice: \n");
        }

    }
}
