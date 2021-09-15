using System;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndnumber = new Random();
            int RandomNumber = rndnumber.Next(1, 11);//number 1 kuni 10
            Console.WriteLine(RandomNumber);
            if (RandomNumber > 5)
            {
                Console.WriteLine($"Juhuslik number on {RandomNumber}, see on suurem, kui 5.");
            }
            else if (RandomNumber < 5)
            {
                Console.WriteLine($"Juhuslik number on {RandomNumber}, see on väiksem kui 5.");
            }
            else
            {
                Console.WriteLine("Juhuslik number ongi 5.");
            }
        }  
    }


}
