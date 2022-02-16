using source.classes.models;
using source.classes.behaviors;


namespace source.classes.models.character_types
{
    public class WillTurner : Character
    {
        public WillTurner()
        {
            Name = "Will Turner";
            Health = 100;
            MaxDefense = 4;
            MaxPower = 20;
            PrimaryAttackBehavior = new SwordAttack();
            SecondaryAttackBehavior = new HandsomeShockAttack();
            DefendBehavior = new Block();
        }
    }
}