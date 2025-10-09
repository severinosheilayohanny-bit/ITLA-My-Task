/*
    Sheila Severino.
    Matricula: 2024-1693
    Programacion I
*/

using System;

public class Evenorodd
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Detecting Even or Odd ---");

        Console.WriteLine("Please, mi loco, introduce a NUMBER");

        string firsttext = Console.ReadLine();

        int usernumber;

        //I use this to try and convert the text to number and for the code to work properly.
        if (int.TryParse(firsttext, out usernumber))
        {
            //This is basic to know if the number inserted before is even or odd
            if (usernumber % 2 == 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"The number {usernumber} is Even, verygud mi loco");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine($"The number {usernumber} is ODD");
            }
        }
        else
        {
            //If the user introduce something that is not a number it will come to this
            Console.WriteLine(" ");
            Console.WriteLine("Error: That is invalid, is not a number, how will I know if is Even or Odd :/");
        }

        Console.WriteLine(" ");

        Console.WriteLine("Press any key to go out. Thank you for being here mi loco...");
        Console.ReadKey();
    }
}