using System;
using source.interfaces;

namespace source.classes.behaviors
{
    public class DistractEnemy : IPrimaryAttack
    {
        public double Attack(string attackerName, double maxStrength)
        {
            double strength = new Random().Next(0, Convert.ToInt32(maxStrength));
            Console.WriteLine($"{attackerName} Distract Enemy Attack of {strength}");
            return strength;
        }
    }
}