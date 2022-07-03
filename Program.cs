//Console.WriteLine("Hello, World!");
using System;

namespace VScode {
  class Program { 
    
    static void Main(string[] args) {

        //Adding new C# class files || Create new objects
        //Game myHumen = new Game();
        // Console.WriteLine(myHumen.Calculation(2, 3));

        // ############## Game ####################
          Game p = new Game();
          p.GuessTheNumber();
        // ############## End Game ####################
        
        int x = 10;
        double c = 20;
        string t = "Test";

        Console.WriteLine("Hello World! lol"); 
        Console.WriteLine("x = {0}, t = {1}", x, t);

        string userInput;

        Console.WriteLine("What is your name?");
        //With Console.ReadLine() you can input things. Its like scanner in java 
        userInput = Console.ReadLine();

        Console.WriteLine("Nice too meet you {0}", userInput);
        // Read and write int and convert it to computer knowing 
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("your number is {0}", input);

        int test; 
        test = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("your second number is {0}", test);

        // Kreis Radius berechnen :D
        double pi = 3.14;
        double radius;
        radius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(pi * (radius*radius));
    }
  }
}