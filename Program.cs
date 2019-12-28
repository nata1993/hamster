/*
2. inside the class, create methods:
- to display the base information about the animal
- to display lifespan
- to display weight
- to make the animal eat and gain weight(+ 0.2 with every food intake)
- to make the animal exercise and lose weight(-0.1 with every run)
2. Create an object hamster, give it a name and the weight
3. Make your hamster live ten cycles(using the for-loop), inside this for-loop, do not forget to feed your hamster
4. Once your hamster's weight reaches the point of 0.7, make him run to lose some weight to get it back to normal (let's assume that 0.7 is the normal weight).
5. Once the cycle of 10 rounds is over the hamster dies (I'm sorry, we can't help it).*/

using System;
using static System.Console;

namespace Hamster
{
    class Animal
    {
        public string name;
        public int age;
        public double weight;
        public int lifespan;

        public void PrintAnimalBaseInfo()
        {
            WriteLine($"Animal name: {name}");
            WriteLine($"Animal age:  {age}");
            WriteLine($"Animal weight: {weight}");
            WriteLine($"Animal lifespan: {lifespan}");
        }

        public void EatingRunning()
        {

            for (double i = 0; i < 1; i += 0.2)
            {
                weight += 0.2;
                WriteLine($"\n {name} eats and gains weight. Weight increased by 0,2");
                WriteLine($" {name} weight is now {Math.Round(weight, 2)}");

                if (weight >= 0.7)
                {
                    for (double j = weight; j > 0.7; j -= 0.1)
                    {
                        weight -= 0.1;
                        WriteLine($"\n {name} is now fat, very fat... {name} does the excercice - running.");
                        WriteLine($" {name} weight is now {Math.Round(weight, 2)}");
                    }
                }

                age++;
                lifespan -= 1;

                if (lifespan == 0) break;
            }
        }
    }

    class Hamster : Animal
    {
        public Hamster(string _name, int _age, double _weight, int _lifespan)
        {
            name = _name;
            age = _age;
            weight = _weight;
            lifespan = _lifespan;
        }

        public void PrintHamsterInfo()
        {
            WriteLine($" Hamster name: {name}");
            WriteLine($" Hamster age:  {age}");
            WriteLine($" Hamster weight: {weight}");
            WriteLine($" Hamster lifespan: {lifespan}");
        }
    }
    class Program
    {
        static void Main()
        {
            ForegroundColor = ConsoleColor.Red;
            Clear();
            WriteLine("\n Hamster will die soon..... OUH YEEEEEEŠŠŠŠŠŠŠŠŠ :D \n");
            ResetColor();
            ForegroundColor = ConsoleColor.White;

            Hamster hamster = new Hamster("Muki", 0, 0.2, 10);

            hamster.PrintHamsterInfo();
            hamster.EatingRunning();

            ForegroundColor = ConsoleColor.Red;
            WriteLine($"\n {hamster.name} has died at the age of {hamster.age} and at the weight of {Math.Round(hamster.weight, 2)}... HE IS DEAD, YEAAAAAAAH!!! VIIIIIIIIIIIIIIIIIIIII!!!!!!!!!!!!!");
            ForegroundColor = ConsoleColor.White;
            Write($"Hamster died of ");
            ForegroundColor = ConsoleColor.Red;
            WriteLine("STARVATION!!!");
            ForegroundColor = ConsoleColor.White;
        }
    }
}