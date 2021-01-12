
/*
Project: Lab_00
File:    lab15.h
Purpose: Lab 15 function defintions
Author:  ANTHONY HARDMAN
Date:    December 1, 2020
*/

using System;


namespace Lab_00
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // Variables
            int num1 = 0;
            int num2 = 0;
            int greatest = 0;
            bool valid1 = false;
            bool exit = false;

            // Greeting
            Console.WriteLine("Part 1: This program finds the greatest number of a sequence of numbers entered");
            Console.WriteLine("by the user.");
            Console.WriteLine("Part 2: This program sums the integer in the range of two numbers entered by the");
            Console.WriteLine("user.");


            Console.WriteLine("\nPart 1: Find the greatest integer in a sequence of integers");

            while(!exit)
            {
                bool valid = false;

                // Test Greatest
                Greater.TestGreatest();

                // Prompt user for integers
                while (!valid)
                {
                    Console.Write("Please enter integer: ");
                    // Verify input for num1
                    try
                    {
                        num1 = Convert.ToInt32(Console.ReadLine());
                        valid = true;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid Input!");
                    }
                }

                // Break out of loop if input is less than 0
                if (num1 < 0)
                {
                    exit = true;
                }

                greatest = Greater.Greatest(greatest, num1);
            }

            // Output the greatest number in the sequence of numbers
            Console.Write("The greatest number is ");
            Console.WriteLine(greatest);

            Console.WriteLine("\nPart 2: Sum the integers in a determined range");

            // Test SumRange
            Sum.TestSumRange();

            // Prompt user for range value 1
            while (!valid1)
            {
                Console.Write("Please enter integer: ");
                try
                {
                    num1 = Convert.ToInt32(Console.ReadLine());
                    valid1 = true;
                }
                catch
                {
                    Console.WriteLine("Invalid Input!");
                }
            }

            valid1 = false;

            // Prompt user for range value 2
            while (!valid1)
            {
                

                Console.Write("Please enter integer: ");
                try
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                    valid1 = true;
                }
                catch
                {
                    Console.WriteLine("Invalid Input!");
                }
            }

            // Output the sum of the range
            Console.Write("The sum of the integers in the range ");
            Console.Write(num1);
            Console.Write(" and ");
            Console.Write(num2);
            Console.Write(" is ");
            Console.WriteLine(Sum.SumRange(num1, num2));
        }
    }
}
