using System;
using source.interfaces;


namespace source.classes.behaviors
{
    public class Block: IDefend
    {
        double IDefend.Defend(string defenderName, double maxDefense)
        {
            double defensePower = new Random().Next(0,Convert.ToInt32(maxDefense));
            Console.WriteLine($"{defenderName} blocked with {defensePower}");
            return defensePower;
        }
    }
}