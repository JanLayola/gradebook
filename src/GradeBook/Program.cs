﻿using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
    
            var book = new Book("Jan's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);
            
            var result = 0.0;
            var lowGrade = double.MaxValue;
            var highGrade = double.MinValue;

            foreach(double number in grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result += number;
            }

            Console.WriteLine($"The sum grades is {result}");
        
            var average = result / grades.Count;
            Console.WriteLine($"The average grade is {average:N1}"); // :N3 -> round to three decimal places
        
        }
    }
}
