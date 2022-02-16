using source.classes;
using System;

namespace source.classes.models
{
    public class AttackSequence
    {
        public Player Attacker { get; set; }
        public Player Defender { get; set; }

        public AttackSequence(ref Player attacker, ref Player defender)
        {
            Attacker = attacker;
            Defender = defender;
        }

        //possible return values: p,s,x
        private string GetAttackType()
        {
            Console.WriteLine($"\n{Attacker.Name}'s {Attacker.CharacterSelection.Name}, choose your attack move\n");
            Console.WriteLine("ATTACK TIME:");
            Console.WriteLine("p) primary attack");
            Console.WriteLine("s) secondary attack");
            Console.WriteLine("x) forgo attacking");
            string userInput = Console.ReadLine();

            while (true && userInput != "x")
            {
                if (userInput == "p") return "p";
                if (userInput == "s") return "s";

                Console.WriteLine("You did not enter a valid attack. choose either 'p' or 's' or forgo attacking with 'x'");
                userInput = Console.ReadLine();
            }
            return "x";
        }

        //Always returns []Attacker, defender] in first position and player 2 in second postion
        public void Attack()
        {
            double attackingPower = 0;
            double defendingPower = 0;

            string attackType = GetAttackType();
            double typeBonus = GetTypeBonus();


            switch (attackType)
            {
                case "p":
                    attackingPower = this.Attacker.CharacterSelection.PrimaryAttackBehavior.Attack(this.Attacker.CharacterSelection.Name, this.Attacker.CharacterSelection.MaxPower);
                    defendingPower = this.Attacker.CharacterSelection.DefendBehavior.Defend(this.Defender.CharacterSelection.Name, this.Defender.CharacterSelection.MaxDefense);
                    break;
                case "s":
                    attackingPower = this.Attacker.CharacterSelection.SecondaryAttackBehavior.Attack(this.Attacker.CharacterSelection.Name, this.Attacker.CharacterSelection.MaxPower);
                    defendingPower = this.Attacker.CharacterSelection.DefendBehavior.Defend(this.Defender.CharacterSelection.Name, this.Defender.CharacterSelection.MaxDefense);
                    break;
            }
            //this eliminates the problem of negative numbers where the defense is higher than the attacking. we don't want to add health points.
            double diff = attackingPower - defendingPower;
            if ((attackingPower - defendingPower) < 0)
            {
                diff = 0;
            };

            //calc damage
            double damageDone = (diff) * typeBonus;
            Console.WriteLine($"{Attacker.CharacterSelection.Name}, dealt {damageDone} to {Defender.CharacterSelection.Name}!");

            //checking to make sure health is nevery negative
            if (Defender.CharacterSelection.Health - damageDone < 0)
            {
                Defender.CharacterSelection.Health = 0;
            }
            else
            {
                Defender.CharacterSelection.Health = Defender.CharacterSelection.Health - damageDone;
            }
        }

        public double GetTypeBonus()
        {
            if (Attacker.CharacterSelection.Name == "Jack Sparrow" && Defender.CharacterSelection.Name == "Will Turner")
            {
                Console.WriteLine("Jack Sparrow got an extra 20% bump in his attack because he overpowers Will Turner");
                return 1.2;
            }
            else if (Attacker.CharacterSelection.Name == "Will Turner" && Defender.CharacterSelection.Name == "Davy Jones")
            {
                Console.WriteLine("Will Turner got an extra 20% bump in his attack because he overpowers Davy Jones");
                return 1.2;
            }
            else if (Attacker.CharacterSelection.Name == "Davy Jones" && Defender.CharacterSelection.Name == "Jack Sparrow")
            {
                Console.WriteLine("Davy Jones got an extra 20% bump in his attack because he overpowers Jack Sparrow");
                return 1.2;
            }
            else return 1;
        }
    }
}