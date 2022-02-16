
using System;
using source.classes;

namespace source.classes.models
{
    public class Gameplay
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public Gameplay()
        {
            GameInit();
            Player1 = new Player(1);
            Player2 = new Player(2);
        }

        private void GameInit()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Video Game: Battle of the Carribean!\n");
            Console.WriteLine("Press any key to begin Character selection....");
            Console.ReadKey();
        }

        public void PrintNames()
        {
            Console.WriteLine(Player1.ToString());
            Console.WriteLine(Player2.ToString());
        }

        public void StartBattle()
        {
            Console.Clear();
            Console.WriteLine("LET THE BATTLE COMMENCE!");
        }

        public void BattleMain()
        {
            bool isWinner = false;
            Player attackingPlayer = Player1;
            Player defendingPlayer = Player2;

            while(!isWinner)
            {
                AttackSequence attackSequence = new AttackSequence(ref attackingPlayer,ref defendingPlayer);
                attackSequence.Attack();
                Console.WriteLine("Press Any key to move onto the next attack phase...");
                Console.ReadKey();
                ScoreBoard();
        
                //Check if there is a winner
                int winner = IndexOfWinner();
                if (winner == 1){
                    Console.WriteLine(Player1.Name + " is the winner of this game using " + Player1.CharacterSelection.Name);
                    return;
                }else if (winner == 2)
                {
                     Console.WriteLine(Player2.Name + " is the winner of this game using " + Player2.CharacterSelection.Name);
                    return;
                }

                //SwitchPlayers
                if (attackingPlayer.ToString() == Player1.ToString())
                {
                    attackingPlayer = Player2;
                    defendingPlayer = Player1;
                }
                else{
                        attackingPlayer = Player1;
                        defendingPlayer = Player2;
                }
            }

        }
        //returns 0 if no winner, returns 1 if player one is winner, return 2 if player 2 is winnner
        private int IndexOfWinner()
        {
            if(Player1.CharacterSelection.Health <= 0) return 2;
            if(Player2.CharacterSelection.Health <= 0) return 1;
            return 0;
        }

        public void ScoreBoard()
        {
            Console.Clear();
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(Player1.ToString() + "   HEALTH:" + Player1.CharacterSelection.Health);
            Console.WriteLine(Player2.ToString() + "   HEALTH:" + Player2.CharacterSelection.Health);
            Console.WriteLine("*****************************************************************");
        }

        


    }
}