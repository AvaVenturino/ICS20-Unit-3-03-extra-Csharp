// Created by: Ava Venturino
// Created on: April 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double radius;
        double volume;
        //input
        Console.WriteLine("This program finds the volume of a sphere.");
        Console.WriteLine("");
        Console.WriteLine("Formula = 4/3πr³");
        Console.WriteLine("");
        Console.Write("Enter the radius of the sphere (cm): ");
        radius = Convert.ToInt32(Console.ReadLine());

        //process
        volume = 4/3 * Math.PI * Math.Pow(radius, 3);

        //output
        Console.WriteLine("");
        Console.Write("Volume of the sphere = " + volume.ToString("0.00") + " cm³");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}