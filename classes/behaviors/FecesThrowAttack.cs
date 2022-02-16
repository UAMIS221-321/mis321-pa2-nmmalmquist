using System;
using source.interfaces;


namespace source.classes.behaviors
{
    public class FecesThrowAttack : ISecondaryAttack
    {
        public double Attack(string attackerName, double maxStrength)
        {
            double strength = new Random().Next(0,Convert.ToInt32(maxStrength));
            Console.WriteLine($"{attackerName} threw feces with attack strength {strength}");
            return strength;
        }
    }
}