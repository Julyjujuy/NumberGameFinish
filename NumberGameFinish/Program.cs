using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGameFinish
{
    internal class Program
    {

        static int Generatenumber(int min, int max)
        {
            var rand = new Random();
            var number = rand.Next(min, max);
            //Console.WriteLine(number);
            return number;

        }

        static bool Checknumber(int guess, int randomnumber)
        {
            if (guess == randomnumber)
            {
                Console.WriteLine("You win!");
                return true;
            }
            if (guess < randomnumber + 5 && guess > randomnumber - 5)
            {
                Console.WriteLine("You're Close!");
                return false;
            }

            if (guess < randomnumber)
            {
                Console.WriteLine("You are too low");
                //return false;   
            }
            if (guess > randomnumber)
            {
                Console.WriteLine("You are too high");
                //return false;

            }
            return false;

        }
        static void Main(string[] args)
        {
            //Print Small Introduction with Rules
            Console.WriteLine("Hello. I have became Sentient. I can think of numbers now. Would you like to play a game with me? You have 5 Attemps to guess the number");

            //Generate a random number
            var randomnumber = Generatenumber(1, 100);

            bool result = false;
            int counter = 0;
            while (counter < 5)
            {
                //Ask user to guess the number
                Console.WriteLine("Please Guess the Number I thought");

                string userInput = Console.ReadLine();
                int guess = Convert.ToInt32(userInput);
                //Check user input

                result = Checknumber(guess, randomnumber);

                if (result == true)
                {
                    break;
                }
                counter = counter + 1;
                //counter++

            }
            if (counter == 5)
            {
                Console.WriteLine("Oh no! You don't have any more attemps left!");
            }
            //End loop if user Wins
            Console.ReadLine();


        }
    }
}
