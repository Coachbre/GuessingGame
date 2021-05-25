using System;

Main();
//run Main function

void Main() 
//all functions are called/ran in main
{
Console.WriteLine("Come guess the secret number, baby!");
Console.WriteLine("----------------------------------");
Console.WriteLine();

Console.Write("What is your guess?");
string userAnswer = Console.ReadLine();

string secretAnswer = "42";

if (userAnswer == secretAnswer) {
    Console.WriteLine("Thats correct! Yay you!");
} else
{
    Console.WriteLine("No. You're not good at this... Stick to C#");
}
}

