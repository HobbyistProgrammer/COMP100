using System;

/**
 * Name: Benton Le
 * Assignment: Lab 5 - For, While Statements
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 02/23/2021
 * 
 * *** Question 10 ***
 * Write a C program that continuously requests a grade. 
 * If the grade is less than 0 or greater than 100, 
 * your program should print an appropriate message informing the user that an invalid grade has been entered, 
 * else the grade should be added to a total. 
 * If the grade is 999, the program should exit the loop and display the sum, number of valid grades and the average of the valid grades entered.
 * (You must NOT display an invalid message)P.S. The value 999 is use to terminate the cycle and should not be used in any of the calculation. 
 * You must not display an “Invalid grade"
**/

namespace Question10
{
    class Question10
    {
        static void Main(String[] args)
        {
            double gradeTotal = 0;
            int gradeCount = 0;
            while(1 == 1)
            {
                Console.Write("Please enter a grade(999 to Stop): ");
                int grade = Convert.ToInt32(Console.ReadLine());
                if (grade < 0 || grade > 100)
                {
                    if(grade == 999)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: Please enter a grade between 0 and 100");
                        continue;
                    }
                }
                else
                {
                    gradeTotal += grade;
                    gradeCount++;
                }
            }

            Console.WriteLine($"# of Grades: {gradeCount}, Average Grade: {(gradeTotal / gradeCount):F}");
        }
    }
}
