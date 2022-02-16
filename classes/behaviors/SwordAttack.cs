using System;
using source.interfaces;

namespace source.classes.behaviors
{
    public class SwordAttack : IPrimaryAttack
    {
        public double Attack(string attackerName, double maxStrength)
        {
            double strength = new Random().Next(0, Convert.ToInt32(maxStrength));
            Console.WriteLine($"{attackerName} sword attack of {strength}");
            return strength;
        }
    }
}