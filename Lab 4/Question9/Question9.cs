using System;

/**
 * Name: Benton Le
 * Assignment: Lab 4 - Do While Statements
 * Course: COMP100 - 001
 * Professor: Narendra Pershad
 * Date: 02/16/2021
 * 
 * *** Question 9 ***
 * To display the sum of all the multiples of 3 between 1,000,000 and 2,000,000. (Answer = 499, 999, 500, 000). 
 * If you suspect that a value might be larger than 2 billion (as is the case here), then the type of sum should be a long and not an int. 
 * [Hint: like the C (currency) and the F (decimal) format specifiers, there is also a N specifier
 * 
**/

namespace Question9
{
    class Question9
    {
        static void Main(String[] args)
        {
            long total = 0;
            long iterator = 1000002;
            const long limit = 2000000;

            do
            {
                   total += iterator;
                   iterator += 3;
                
            } while (iterator < limit);
            Console.WriteLine($"Sum: {total:N0}");
        }
    }
}
