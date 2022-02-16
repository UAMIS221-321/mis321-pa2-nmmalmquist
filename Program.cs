using System;
using source.classes.models;

namespace source
{
    class Program
    {
        static void Main(string[] args)
        {
            Gameplay thisGame = new Gameplay();
            thisGame.StartBattle();
            thisGame.ScoreBoard();
            thisGame.BattleMain();
        }
    }
}
