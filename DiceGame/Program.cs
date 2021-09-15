using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus on kaks mängijat
            //mõlemad mängijad viskavad täringut
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskas rohkem ongi võitja
            //programm kuulutab võitjat

            Random rndnumber = new Random();

            string Playerone = ("Sebastian");
            string Playertwo = ("Martin");

            int Sebastianthrow = rndnumber.Next(1, 7);
            int Martinthrow = rndnumber.Next(1, 7);

            Console.WriteLine($"{Playerone} threw {Sebastianthrow};");
            Console.WriteLine($"{Playertwo} threw {Martinthrow};");
            if(Sebastianthrow > Martinthrow)
            {
                Console.WriteLine($"{Playerone} Wins!");

            }
           
               else if (Sebastianthrow < Martinthrow)
            {
                Console.WriteLine($"{Playertwo} Wins!");
                
            }
            else
            {
                Console.WriteLine("draw! let them try again!");

            }

        }

    }
}


