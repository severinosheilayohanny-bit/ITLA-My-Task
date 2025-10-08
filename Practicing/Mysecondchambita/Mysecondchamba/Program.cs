
//Sheila Severino
//Matricula: 2024-1693

using System;

public class VariableExample
{
    public static void Main(string[] args)
    {
        string myname = "Sheila Severino";
        int myage = 21;
        double mygrade = 3.9;
        char favoriteletter = 'S';
        bool imadult = true;

        const int majorityofage = 18;

        Console.WriteLine("--- Homework Examples ---");
        Console.WriteLine($"My name: {myname}");
        Console.WriteLine($"My age: {myage}");
        Console.WriteLine($"Final Grade of myself: {mygrade}");
        Console.WriteLine($"Favorite letter: {favoriteletter}");
        Console.WriteLine($"Im I an adult?: {imadult}");
        Console.WriteLine($"Majority of age: {majorityofage}");

        int semesterHours = 15;

        Console.WriteLine("   ");
        Console.WriteLine("----------  I NEED SOME SPACELINE BRO  ----------- ");
        Console.WriteLine("   ");
        Console.WriteLine($"This is how I started my semester: {semesterHours}");

        semesterHours++;
        Console.WriteLine($"But then I added another hour, im crazy: {semesterHours}");

        semesterHours--;
        Console.WriteLine($"I coulnt handled it, so I take it back: {semesterHours}");

        int totalsubject = semesterHours / 3;

        Console.WriteLine($"Every subject is 3 hours, so I have: {totalsubject} subjects in total");
        Console.WriteLine($"If I substract 1 subject I would have: {totalsubject - 1} in total");
        Console.WriteLine($"If I add another subject I would have: {totalsubject + 1} in total");
        Console.WriteLine($"So. thats why if I have 5 subjects I would have {totalsubject * 3} hours in total");

        Console.WriteLine("   ");
        Console.WriteLine("----------  I NEED SOME SPACELINE BRO  ----------- ");
        Console.WriteLine("   ");
        
        float bignumber = 10152466.25f; /*That cannot be done, cause it exceeds the limit of float, it should be a double instead, 
        if we want to do it we have to put an "f" at the end of the number like this: 10152466.25f */

        byte smallByte = 5;

        //Here I can put single line comments

        /* This is how I can put multiple lines,
        it's super easy */

        Console.WriteLine($"Current System Date and Time: {DateTime.Now}");


    }
}