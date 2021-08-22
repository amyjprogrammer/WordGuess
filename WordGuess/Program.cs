using System;

namespace WordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";

            Console.Write("Please enter your guess for the word: ");
             string guess = Console.ReadLine();

            while (guess != secretWord)
            {
               Console.WriteLine("Wrong word.");
               Console.Write("Please try again: ");
               guess = Console.ReadLine();
              
            }  
          
            Console.WriteLine("You won!");
            
        }
    }
}
