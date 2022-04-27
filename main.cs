// Created by: Kaitlyn Ip
// Created on: April 2022 
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        int userInteger;
        Console.WriteLine("Enter a number (positive or negative):");
        userInteger = int.Parse(Console.ReadLine());
        if (userInteger > -1)
        {
            userInteger = Convert.ToInt32(Console.Read());
            Console.WriteLine("The integer you entered is positive.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("The integer you entered is negative.");
        }
    }
}