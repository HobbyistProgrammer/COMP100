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
 *  *** Question 5 ***
 *  
 *  Write an application that asks a user to enter an IQ score. 
 *  If the score is a number less than 0 or greater than 200, issue an error message; 
 *  otherwise, issue an “above average”, “average”, or “below average” message for scores over, at, or under 100, 
 *  respectively
 * 
 **/
namespace Question_5
{
    class Question_5
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter your IQ score: ");
            int iq = Convert.ToInt32(Console.ReadLine());

            if (iq <= 0 || iq > 200)
                Console.WriteLine("ERROR: Please enter a valid IQ Score.");
            else if (iq > 100 && iq < 200)
                Console.WriteLine("IQ Score: you are above average.");
            else if (iq > 0 && iq < 100)
                Console.WriteLine("IQ Score: you are below average.");
            else
                Console.WriteLine("IQ Score: You are average.");
        }
    }
}
