using System;

/**
 * Name: Benton Le
 * Assignment: Lab 3
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 02/9/2021
 * 
 * *** Question 4 ***
 * Write a program that prompts the user for the number of courses and residency status 
 * (domestic or international) and calculates tuition cost. Cost is calculated based on the table below.
 * 
 * -------------------------------------
 * | Domestic       | $325 per course  |
 * | International  | $1375 per course |
 * -------------------------------------
 * 
 * You decide how you want the user to enter her/his residency status and prompt accordingly, 
 * also you should use named constants for the cost per course
 * 
**/

namespace Question4
{

    class Question4
    {

        const int Domestic = 325, International = 1375;

        static void Main(String[] args)
        {
            int courses;
            char status;

            Console.Write("Enter number of courses attending: ");
            courses = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your residency status Domestic or International(D/I): ");
            status = Convert.ToChar(Console.ReadLine());

            // This code works as a ToUpper() for chars.
            if (status == 'd' || status == 'i')
                status = (char)(status - 32);

            switch (status)
            {
                case 'D':
                    Console.WriteLine($"# Courses: {courses}, Status: {status}, Cost: {courses * Domestic:C}");
                    break;
                case 'I':
                    Console.WriteLine($"# Courses: {courses}, Status: {status}, Cost: {courses * International:C}");
                    break;
                default:
                    Console.WriteLine("ERROR: Please enter a valid character...");
                    break;
            }
        }
    }
}
