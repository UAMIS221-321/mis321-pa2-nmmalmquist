using System;
using source.interfaces;


namespace source.classes.behaviors
{
    public class KrabbyPattyAttack : ISecondaryAttack
    {
        public double Attack(string attackerName, double maxStrength)
        {
            double strength = new Random().Next(0,Convert.ToInt32(maxStrength));
            Console.WriteLine($"{attackerName} threw aton of burgers with strength of {strength}");
            return strength;
        }
    }
}