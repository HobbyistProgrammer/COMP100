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
 *  *** Question 6 ***
 * 
 * Write a console-based program that prompts the user for an hourly pay rate and hours worked. 
 * Compute gross pay (hours times pay rate), withholding tax, and net pay (gross pay minus withholding tax). 
 * Withholding tax is computed as a percentage of gross pay based on the follow
 * 
 * |-----------------------------------------------------|
 * | Gross Pay                   | Witholding Percentage |
 * | Up to and including 300.00  | 10%                   |
 * | More than 300.00            | 12%                   |
 * |-----------------------------------------------------|
 **/

namespace Question_6
{
    class Question_6
    {
        static void Main(String[] args)
        {
            double payRate, hoursWorked, grossPay, netPay, tax;

            Console.Write("Please enter your hourly pay rate: ");
            payRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter your hours worked: ");
            hoursWorked = Convert.ToDouble(Console.ReadLine());

            grossPay = payRate * hoursWorked;
            if (grossPay <= 300.00 && grossPay > 0) {
                tax = 0.10;
                netPay = grossPay - (grossPay * tax);
            }
            else {
                tax = 0.12;
                netPay = grossPay - (grossPay * tax);
            }
            Console.WriteLine($"Gross Pay: {grossPay:C}, Witholding Tax: {tax * 100}%, Net Pay: {netPay:C}");
        }
    }
}
