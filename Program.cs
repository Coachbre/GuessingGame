using System;

Main();


void Main()

{
    Console.WriteLine("Come guess the secret number!");
    Console.WriteLine("----------------------------------");
    Console.WriteLine();

    GetAnswer();
}


void GetAnswer()
{


    int chances = 4;

    while (chances > 0)
    {
        Console.WriteLine("What is your guess?");
        string userAnswer = Console.ReadLine();

        string secretAnswer = "42";

        if (userAnswer == secretAnswer)
        {
            Console.WriteLine("Thats correct! Yay you!");
            chances--;
        }
        else
        {
            Console.WriteLine("Not quite. Try again!");
            chances--;
        }

    }
}

