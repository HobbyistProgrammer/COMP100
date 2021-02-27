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
 *  *** Question 4 ***
 *  
 *  Write a console-based program that accepts a user’s message and determines whether it is 
 *  short enough for a social networking service that does not accept messages of more than 140 characters.
 *  [Hint: if the user’s input is assigned to the variable message then message.
 *  Length will automatically give you the number of characters in the variable messag
 * 
 * 
 **/

namespace Lab_2
{
    class Question_4
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Please type message for the Social Networking Service: ");
            
            string message = Console.ReadLine();
            if(message.Length > 140)
                Console.WriteLine($"Message Length: {message.Length}, This message is not suitable for the Social Networking Service.");
            else
                Console.WriteLine($"Message Length: {message.Length}, This message is suitable for the Social Networking Service");
        
        }
    }
}
