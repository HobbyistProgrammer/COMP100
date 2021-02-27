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
 *  *** Question 7 ***
 * 
 * The average cost of a college textbook is $125. 
 * There is a premium of 20% on hardcover text and a discount of 5% on sales of more than 4 textbooks. 
 * Write a program to prompt the user for the appropriate inputs and compute and display the before-tax cost of the textbooks.
 * 
 * Sample calculation: 
 * price of 10 hardcover text = 10 * 125 + premium – discount
 * price = 1250 + 20% of 1250 – 5% of 1250
 * price = $1437.50
 * 
 * price of 8 softcover text = 8 * 125 – discount
 * price = 1000  – 5% of 1000
 * price = $950
 * 
 * price of 2 softcover text = 2 * 125
 * price = $250
 **/

namespace Question_7
{
    class Question_7
    {
        static void Main(String[] args)
        {
            Console.Write("Do you wish to purchase Hardcover or Softcover textbooks(H/S)?: ");
            char bookType = Convert.ToChar(Console.ReadLine());
            if (bookType == 'S' || bookType == 'H' || bookType == 's' || bookType == 'h')
            {
                double total = 0, premium = 0.20;
                
                Console.Write("How many textbooks would you like to purchase?: ");
                int numOfBooks = Convert.ToInt32(Console.ReadLine());

                double subtotal = 125 * numOfBooks;
                if (numOfBooks > 4)
                {
                    double discount = subtotal * 0.05;
                    if (bookType == 'H' || bookType == 'h')
                        total = subtotal + (subtotal * premium) - (discount);
                    else
                        total = subtotal - discount;
                }
                else
                {
                    if (bookType == 'H' || bookType == 'h')
                        total = subtotal + (subtotal * premium);
                    else
                        total = subtotal;
                }

                Console.WriteLine($"\nBook Type: {((bookType == 's' || bookType == 'S') ? "Softcover" : "Hardcover + 20% Premium")}," +
                                  $" Numbers of Books: {(numOfBooks > 4 ? $"{numOfBooks} + 5% Discount" : $"{numOfBooks}")}\nGrand Total: {total:C}");
            }
            else
                Console.WriteLine("ERROR: Please enter a valid input...");
        }
    }
}
