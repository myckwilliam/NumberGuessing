using System;

class MainClass {

    public static int  Random10()
    {
        Random rand = new Random();
        int number = rand.Next(10);
        return number;
    }
    public static void Conditionals()
    {
        int realNumber = Random10();
        Console.Write("What's the number? ");
        int guessNumber = int.Parse(Console.ReadLine());
        if (guessNumber == realNumber)
        {
            Console.WriteLine("Congratulations! You're right.");
            Console.WriteLine("The number is {0}.", realNumber);
        }
        else
        {
            Console.WriteLine("You missed!");
            Console.WriteLine("The number is {0}.", realNumber);
        }
    }
    
    public static void Main (string[] args) 
    {
        int a = 0;
        while(a==0)
        {
            Conditionals();
            Console.Write("Type 0 to retry or 1 to finish the game: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
        }
    }    
    
}