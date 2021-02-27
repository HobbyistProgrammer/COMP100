using System;

/**
 * Name: Benton Le
 * Assignment: Lab 4 - Do While Statements
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 02/16/2021
 * 
 * *** Question 11 ***
 * A machine purchased for $28,000 depreciates at a rate of $4,000 a year for seven years. 
 * Writeand run a C# program that computes and displays a depreciation table for seven years. 
 * The table should have the form:
 * 
 *                            END-OF-YEAR         ACCUMULATED
 * YEAR      DEPRECIATION        VALUE           DEPRECIATION
 * ----      ------------      ------------      ------------ 
 * 1            4000            24000               4000 
 * 2            4000            20000               8000 
 * 3            4000            16000              12000 
 * 4            4000            12000              16000 
 * 5            4000             8000              20000 
 * 6            4000             4000              24000 
 * 7            4000                0              28000
 * 
**/

namespace Question11
{

    class Question11
    {
        const int depreciation = 4000;

        static void Main(String[] args) {

            Console.WriteLine(String.Format(" \n {0, 37} {1, 17}", "END-OF-YEAR", "ACCUMULATED"));
            Console.WriteLine(String.Format(" {0, 5} {1, 15} {2, 12} {3, 20}", " YEAR", "DEPRECIATION", "VALUE", "DEPRECIATION"));
            Console.WriteLine(String.Format(" {0, 5} {1, 15} {2, 12} {3, 20}", "----", "------------", "-----", "------------"));

            int year = 1, price = 24000, accum = depreciation;


            do
            {
                Console.WriteLine(String.Format(" {0, 5} {1, 15} {2, 12} {3, 20}", year, depreciation, price, accum));

                price -= depreciation;
                accum += depreciation;
                year++;
            } while (year < 8);
            Console.WriteLine("");
        }
    }
}
