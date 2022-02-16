using System;
using source.interfaces;


namespace source.classes.behaviors
{
    public class DirtyBombAttack : IPrimaryAttack
    {
        public double Attack(string attackerName, double maxStrength)
        {
            double strength = new Random().Next(0,Convert.ToInt32(maxStrength));
            Console.WriteLine($"{attackerName} threw a dirty bomb of attack strength {strength}");
            return strength;
        }
    }
}