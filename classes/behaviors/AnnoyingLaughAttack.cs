using System;
using source.interfaces;


namespace source.classes.behaviors
{
    public class AnnoyingLaughAttack : IPrimaryAttack
    {
        public double Attack(string attackerName, double maxStrength)
        {
            double strength = new Random().Next(0,Convert.ToInt32(maxStrength));
            Console.WriteLine($"{attackerName} laughed like an idiot which cause {strength} points of damage");
            return strength;
        }
    }
}