﻿using System;
/*
 ********************************************************************************
 * Programming I -  Test 3 (Version D)
 *      Name: Xuan Tri Nguyen
 *      Date:April 17th 2024
 * Student #:301388576
 *  Solution: VersionD.exe
 * Test 3 - 25% of final grade
 * 
 ******************************************************************************** 
 */

namespace XuanTriNguyen_versionD
{
    class VerD
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Display();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {                    
                    case 3:
                        DemoQuestion3();
                        break;
                    case 4:
                        DemoQuestion4();
                        break;
                    case 5:
                        DemoQuestion5();
                        break;
                    case 6:
                        DemoQuestion6();
                        break;
                    default:
                        Console.WriteLine("You enter the wrong number");
                        break;
                }
            }
            while (choice != 0);
        }
        static void Display()
        {
            Console.WriteLine("|==================Xuan Tri Nguyen=====================|");
            Console.WriteLine("|           3. Working with array of integer           |");
            Console.WriteLine("|           4. Volume Conversion                       |");
            Console.WriteLine("|           5. Simple pendulum                         |");
            Console.WriteLine("|           6. Calculate Ontario Tax                   |");
            Console.WriteLine("|                                                      |"); 
            Console.WriteLine("|           X. To exit the program                     |");
            Console.WriteLine("|======================================================|");
            Console.Write("Press the letter corresponding to your choice-> ");
        }
        static void DisplayMultiplesOfThree(int[] array)
        {            
            foreach (int num in array)
            {
                if (num % 3 == 0)
                {
                    Console.Write($"{num}  ");
                }
            }
        }       
        static void DisplayIntArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].ToString("D2"));
                if (i < array.Length - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        public static int[] GenerateIntArray(int size)
        {            
            Random random = new Random();
            int[] resultArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                resultArray[i] = random.Next(100); 
            }
            return resultArray;
        }  
        static void DemoQuestion3()
        {
            Console.WriteLine("\n\n**********Begin Question 3 **********");
            int[] numbers = GenerateIntArray(30);
            DisplayIntArray(numbers);
            Console.WriteLine();
            DisplayMultiplesOfThree(numbers);
            Console.WriteLine("\n**********End Question 3 **********\n\n");
        }
        static void VolumeConversion(double liters, out double gallons, out double ounces, out double milliliters)
        {
            gallons = liters * 0.2642;
            ounces = liters * 33.8135;
            milliliters = liters * 1000;
        }
        static void DemoQuestion4()
        {            
            Console.WriteLine("\n\n**********Begin Question 4 **********");
            double liters = 0.5;
            double gallons, ounces, milliliters;
            VolumeConversion(liters, out gallons, out ounces, out milliliters);
            Console.WriteLine($"{liters}L is equivalent to {gallons}gal or {ounces}oz, or {milliliters}ml");                     
            liters = 1.0;
            VolumeConversion(liters, out gallons, out ounces, out milliliters);
            Console.WriteLine($"{liters}L is equivalent to {gallons}gal or {ounces}oz, or {milliliters}ml");
            Console.WriteLine("\n**********End Question 4 **********\n\n");
        } 
        static double SimplePendulum(double length)
        {
            return Math.Sqrt(length / 9.81);
        }
        static void DemoQuestion5()
        {
            Console.WriteLine("\n\n**********Begin Question 5 **********");
            double length1 = 0.5; 
            double period1 = SimplePendulum(length1);
            Console.WriteLine($"A length {length1}m will give a time {period1}s");
            double length2 = 0.9;
            double period2 = SimplePendulum(length2);
            Console.WriteLine($"A length {length2}m will give a time {period2}s");
            Console.WriteLine();
            Console.WriteLine("\n**********End Question 5 **********\n\n");
        }
        const double TaxRate1 = 0.0505; 
        const double TaxRate2 = 0.0915; 
        const double TaxRate3 = 0.1316; 
        const double TaxThreshold1 = 41536.0; 
        const double TaxThreshold2 = 83075.0; 
        public static double CalculateOntarioTax(double income)
        {
            double tax = 0.0;

            if (income <= TaxThreshold1)
            {
                tax = income * TaxRate1;
            }
            else if (income <= TaxThreshold2)
            {
                tax = TaxThreshold1 * TaxRate1 + (income - TaxThreshold1) * TaxRate2;
            }
            else
            {
                tax = TaxThreshold1 * TaxRate1 + (TaxThreshold2 - TaxThreshold1) * TaxRate2 + (income - TaxThreshold2) * TaxRate3;
            }

            return tax;
        }       
        static void DemoQuestion6()
        {
            Console.WriteLine("\n\n**********Begin Question 6 **********");
            double income = 30000.0;
            double taxOwed;
            while (income <= 90000.0)
            {
                taxOwed = CalculateOntarioTax(income);
                Console.WriteLine($"{income:C2} will result in {taxOwed:C2} of tax");   
                income += 30000.0; 
            }
            Console.WriteLine();
            Console.WriteLine("\n**********End Question 6 **********\n\n");
        }
       
    }
}

