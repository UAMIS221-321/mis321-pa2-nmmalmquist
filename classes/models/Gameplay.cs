
using System;
using source.classes;

namespace source.classes.models
{
    public class Gameplay
    {
        public Player[] Players { get; set; }
    

        public Gameplay()
        {
            GameInit();
            Players = new Player[]{new Player(1), new Player(2)};
            
        }

        private void GameInit()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Video Game: Battle of the Carribean!\n");
            Console.WriteLine("Press any key to begin Character selection....");
            Console.ReadKey();
        }


        public void StartBattle()
        {
            Console.Clear();
            Console.WriteLine("LET THE BATTLE COMMENCE!");
        }

        public void BattleMain()
        {
            bool isWinner = false;

            //randomly assigning who goes first
            int rand = new Random().Next(0,2);
            Player attackingPlayer = Players[rand];
            Player defendingPlayer = Players[Math.Abs(rand - 1)];

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
                    Console.WriteLine(Players[0].Name + " is the winner of this game using " + Players[0].CharacterSelection.Name);
                    return;
                }else if (winner == 2)
                {
                     Console.WriteLine(Players[1].Name + " is the winner of this game using " + Players[1].CharacterSelection.Name);
                    return;
                }

                //SwitchPlayers
                if (attackingPlayer.ToString() == Players[0].ToString())
                {
                    attackingPlayer = Players[1];
                    defendingPlayer = Players[0];
                }
                else{
                        attackingPlayer = Players[0];
                        defendingPlayer = Players[1];
                }
            }

        }
        //returns 0 if no winner, returns 1 if player one is winner, return 2 if player 2 is winnner
        private int IndexOfWinner()
        {
            if(Players[0].CharacterSelection.Health <= 0) return 2;
            if(Players[1].CharacterSelection.Health <= 0) return 1;
            return 0;
        }

        public void ScoreBoard()
        {
            Console.Clear();
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(Players[0].ToString() + "   HEALTH:" + Players[0].CharacterSelection.Health);
            Console.WriteLine(Players[1].ToString() + "   HEALTH:" + Players[1].CharacterSelection.Health);
            Console.WriteLine("*****************************************************************");
        }

        


    }
}