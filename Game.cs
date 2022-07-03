//Console.WriteLine("Hello, World!");
using System;

namespace VScode{
    
    class Game {
        
        public void GuessTheNumber(){

            Random random = new Random();
            //A number between 1 and 100
            int returnValue = random.Next(1, 100);
            //Guess 
            int Guess = 0;
            int Leben = 0;

            Console.WriteLine("Guess the Number i m thinking, the number is between 1-100");
            //As long the Guess (Number) is not true or right then continue

                while(Guess != returnValue ) {
                    if(Leben < 2){
                        Guess = Convert.ToInt32(Console.ReadLine());
                    Leben++;
                    if(Guess < returnValue) {
                        Console.WriteLine("No, the number I am thinking of is higher than " + Guess + ". Notice you have " + Leben + " left." );
                    } else if(Guess > returnValue) {
                        Console.WriteLine("No, the number I am thinking of is lower than " + Guess + ". Notice you have " + Leben + " left.");
                    }
                    } else {
                        Console.WriteLine("you are smart");
                        System.Environment.Exit(0);  
                    }
                    
                }
            Console.WriteLine("Well done! The answer was " + returnValue);
            Console.ReadLine();
        
        }
    }
}