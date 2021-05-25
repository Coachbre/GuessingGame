using System;

Main();

void Main() 

{
Console.WriteLine("Come guess the secret number, baby!");
Console.WriteLine("----------------------------------");
Console.WriteLine();

Console.Write("What is your first guess?");
string answer = Console.ReadLine();
Console.Write(answer);
}