using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

/**
 * Name: Benton Le
 * Assignment: Lab 2
 * Course: COMP 100 - 001
 * Professor: Narendra Pershad
 * Date: 02/2/2021
 * 
 *  *** Question 3 ***
 *  
 * If money is left in a particular bank for more than 5 years, 
 * the interest rate given by the bank is 7.5%, else the interest rate is 5.4%. 
 * Write a program that prompt the user for the number of years that the money was 
 * left in the bank and display the appropriate interest rate depending on the value input. 
 * How many runs should you make to very that it works correctly
 * 
 * 
 **/

namespace Lab_2
{
    class Question_3
    {
        static void Main(String[] args)
        {
            double rate = 0;

            Console.Write($"Please enter amount of years amount was left in bank: ");
            int years = Convert.ToInt32(Console.ReadLine());

            if (years > 5)
                rate = 7.5;
            else
                rate = 5.4;

            Console.WriteLine($"Interest rate will be {rate}% after {years} years");
        }
    }
}
