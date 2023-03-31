using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        public static List<>
        public string Location;
        {
            Location = leadsTo;
            leadsTo = null;
        }
    public string Items;
    public string Transportation;
}
    public class Exit
      {
            Exit = null;
      }
        static void Main(string[] args)
        {

            gameTitle();
            first();

        }
public string Location
{
    Island;
    Farm;
    Space;
}
public string Item
{ 
    Weapon;
    Food;
    Water;
}

public string Transportation
{
    Boat;
    Airplane;
    ATV;
}
    

        /* this section will demonstrate writing to the console*/

         static void gameTitle()

        {
            Console.Writeline("Welcome! This is a text adventure game.");
            Console.WriteLine("Press 'Enter' to begin.");
            Console.ReadLine();
            Console.Clear();
            first();

        }

        /* this section will demonstrate switches*/

         static void first()
        {
            string choice;

            Console.WriteLine("You're shipwrecked on an island.");
            Console.WriteLine("What is your biggest concern?");
            Console.WriteLine("1. never being found");
            Console.WriteLine("2. survival");
            Console.WriteLine("3. build a shelter");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "never being found":
                case "found":
                    {
                        Console.WriteLine("You check out the island.");
                        Console.WriteLine("You yell to see if you're alone.");
                        Console.WriteLine("Birds fly over head and monkeys swing through the trees.");
                        Console.WriteLine("Soon you notice a dragon headed towards you.");
                        Console.WriteLine("Unfortunately there is no escape.");
                        Console.ReadLine();
                        gameOver();
                        break;
                    }
                case "2":
                case "survival":
                    {
                        Console.WriteLine("You search for food and water in the area.");
                        Console.WriteLine("You find some food and water nearby and begin tasting it.");
                        Console.WriteLine("After eating and drinking you continue your journey");
                        Console.ReadLine();
                        second();
                        break;
                    }
                case "3":
                case "build":
                case "build a shelter":
                    {
                        Console.WriteLine("You gather materials for building a shelter on the island.");
                        Console.WriteLine("After a few hours you are able to erect a sturdy shelter.");
                        Console.WriteLine("You feel a bit safer but night is soon approaching."); ;
                        Console.ReadLine();
                        second();
                        break;
                    }
                default:
                    {

                        Console.WriteLine("Command is invalid...");
                        Console.WriteLine("Press 'Enter' to restart.");
                        Console.ReadLine();
                        first();
                        break;
                    }
            }
        }

        /* this section will demonstrate using random number generator and also allowing player to enter text response*/

        static void second()
        {
            Random rnd = new Random();
            string[] secondOptions = { "A hurricane is on the horizon, will you seek shelter?",
            "Your head hurts, will you find a cure?",
            "You hear noises in the distance, will you search for the source?"};
            int randomNumber = rnd.Next(0, 3);
            string secText = secondOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);
            Console.WriteLine("option 1");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "yes" || secChoice == "y")
            {
                Console.WriteLine("You feel as if something is wrong, but ignore the feeling and continue.");
                Console.ReadLine();
                Console.Clear();
                third();

            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("You stop for a moment, you feel sharp claws in your back and you're sent soaring in the air.");
                Console.WriteLine("All is pain, followed by darkness.");
                Console.ReadLine();
                gameOver();

            }
            else
            {
                Console.WriteLine("You must reply Yes or no.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                second();
            }

        }

        /* this section demonstrates the use of loops*/

        static void third()

        {
            int Decision;
            Console.WriteLine("A low growl can be heard amongst the trees");
            Console.WriteLine("your stomach sinks and your eyes go wide as you scan the direction of the sound");
            Console.WriteLine("Will you fight or flee? Type 1 or 2.");
            Console.Write("Decision: ");
            int.TryParse(Console.ReadLine(), out Decision);
            int loop = 0;
            bool dead = false;
            while (Decision != 1 && dead == false)
            {
                if (loop <= 0)
                {
                    Console.WriteLine("You are too slow, a dragon sweeps and you fall to the ground.");
                    Console.WriteLine("You are bleeding, will your flee or fight?");
                    Console.Write("Decision: ");
                    int.TryParse(Console.ReadLine(), out Decision);
                    loop++;
                }
                else if (loop >= 1)
                {
                    Console.WriteLine("The dragon grabs you by your shorts, you are hitting and yelling.");
                    Console.WriteLine("Fear and adrenaline surge inside you. Fight or Flee? 1 or 2? ");
                    Console.Write("Decision: ");
                    int.TryParse(Console.ReadLine(), out Decision);
                    dead = true;
                }

            }
            if (dead == true)
            {
                Console.WriteLine("You feel hot air against your skin, and sharp claws tear at your legs");
                Console.WriteLine("All is pain, followed by darkness.");
                Console.ReadLine();
                gameOver();
            }
            else

            {
                Console.WriteLine("You fight with all your might, kicking the dragon in the stomach and causing it to flee.");
                Console.ReadLine();
                youWin();
            }
        }
         static void gameOver()
        {
            Console.Clear();
            Console.WriteLine("You have died.");
            Console.WriteLine("All is good in the world and nature continues it's course.");
            Console.WriteLine("The End");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }
        static void youWin()
        {
            Console.Clear();
            Console.WriteLine("You have survived.");
            Console.WriteLine("An airplane flying over sees your s.o.s.");
            Console.WriteLine("You are saved.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }
    }
public class Exit
{
    Exit = null;
}

} return 0;
