﻿using System;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Number Guessing Game
            var r = new Random();
            //var favNumber = r.Next(1, 10);
            var favNumber = 5;

            Console.WriteLine("Pick a number from 1 - 1000");
            var userInput = int.Parse(Console.ReadLine());

            if(userInpute < favNumber)
            {
                COnsole.WriteLine($"{userInpute} is too low");
            }
            else if(userInput > favNumber) 
            {
                Console.WriteLine($"{ userInpute} is too high");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
