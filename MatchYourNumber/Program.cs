using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchYourNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            NumberRepository yourNumbers = new NumberRepository();

            Console.WriteLine("Welcome to My Game");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            //var message = yourNumbers.Message(name);

            Console.WriteLine("Guess any numbers between 1 to 10");
            bool winner = false;
            while(winner == false)
            {
                int number = int.Parse(Console.ReadLine());
                if (number == 1 || number == 3 || number == 5 || number == 7 || number == 9)
                {
                    Console.WriteLine("Nope!! Your Guess is Wrong! Try One more time.");
                }
                else if (number == 2 || number == 4 || number == 6 || number == 8 || number == 10)
                {
                    Console.WriteLine("Congratulations!! Your Correct");
                    winner = true;
                }
            }
        }
    }
}
