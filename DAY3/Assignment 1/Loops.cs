using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;

class Loops
{
     static void Main(string[] args)
    {

        Console.WriteLine("enter the N to find all primenumber<=N");
        int N = Convert.ToInt32(Console.ReadLine());
        printPrimeNumber(N);

        Console.WriteLine();
        useForEach();
        guessTheNum();

    }

    static void printPrimeNumber(int n)
    {
        for (int num = 2; num <= n; num++)
        {
            bool isPrime = true;

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.Write(num + " ");
            }
        }
    }
    static void useForEach()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        foreach(int n in numbers)
        {
            Console.WriteLine("number is : "+n);
        } 
    }
    static void guessTheNum()
    {
        Random random = new Random();   
        int secretNumber = random.Next(101);
        int guess = 0;
        int chances = 5;
        while (chances>1)
        {
            Console.Write("Enter your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());
            chances--;
            if (guess < secretNumber)
            {
                Console.WriteLine("Too low! Try again.");
                Console.WriteLine($"you have {chances} remaining");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Too high! Try again.");
                Console.WriteLine($"you have {chances} remaining");
            }
            else
            {
                Console.WriteLine(" Correct! You guessed the number.");
            }

           
        }


    }
    
}
