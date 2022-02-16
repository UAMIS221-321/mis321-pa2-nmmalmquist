
using System;
using source.classes.models;

namespace source
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                Console.Clear();
                Gameplay thisGame = new Gameplay();
                thisGame.StartBattle();
                thisGame.ScoreBoard();
                thisGame.BattleMain();

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Would you like to play again?");
                playAgain = PlayAgain();
            }

        }

        public static bool PlayAgain()
        {
    
            string userInput = Console.ReadLine();

            while (true)
            {
                if (userInput.ToLower()[0] == 'y') return true;
                if (userInput.ToLower()[0] == 'n') return false;

                Console.WriteLine("You did not enter a valid response (y/n)");
                userInput = Console.ReadLine();
            }
        }
    }
}
