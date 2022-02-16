using source.classes.models;
using source.classes.behaviors;


namespace source.classes.models.character_types
{
    public class SpongeBob: Character
    {
        public SpongeBob()
        {
            Name = "SpongeBob Squarepants";
            Health = 100;
            MaxDefense = 80;
            MaxPower = 25;
            PrimaryAttackBehavior = new AnnoyingLaughAttack();
            SecondaryAttackBehavior = new KrabbyPattyAttack();
            DefendBehavior = new Block();
        }
    }
}