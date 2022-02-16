using System;
using source.interfaces;

namespace source.classes.behaviors
{
    public class VerbalAssault : ISecondaryAttack
    {
        public double Attack(string attackerName, double maxStrength)
        {
            double strength = new Random().Next(0, Convert.ToInt32(maxStrength));
            Console.WriteLine($"{attackerName} verbal Assault Attack of {strength}");
            return strength;
        }
    }
}