using System;
using source.interfaces;


namespace source.classes.behaviors
{
    public class CannnonFireAttack : IPrimaryAttack
    {
        public double Attack(string attackerName, double maxStrength)
        {
            double strength = new Random().Next(0,Convert.ToInt32(maxStrength));
            Console.WriteLine($"{attackerName} cannon Fire Attacked of {strength}");
            return strength;
        }
    }
}