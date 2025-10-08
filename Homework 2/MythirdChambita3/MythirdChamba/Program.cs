/*
    Sheila Severino
    Matricula: 2024-1693
    Programacion I
*/

using System;

public class EvenorOdd
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Detecting if is even or odd ---");
        Console.WriteLine(" ");

        Console.WriteLine("Please, mi loco, introduce a NUMBER: ");

        //Here I convert the string input to an integer, is an easy way to do it
        int usernumber = int.Parse(Console.ReadLine()!);

        //This is the ternary operator, is like an if else but in one line, i like that more, is more clean
        string Result = (usernumber % 2 == 0) ? "Even" : "Odd";

        Console.WriteLine(" ");
        Console.WriteLine($"The number {usernumber} is {Result}.");

        Console.WriteLine(" ");

        //This is just to make the console wait before closing, is a good practice
        Console.WriteLine("Press any key to go out brother ;)");
        Console.ReadKey();
    }
}