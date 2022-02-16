using source.classes.models;
using source.classes.behaviors;


namespace source.classes.models.character_types
{
    public class JackSparrow: Character
    {
        public JackSparrow()
        {
            Name = "Jack Sparrow";
            Health = 100;
            MaxDefense = 10;
            MaxPower = 35;
            PrimaryAttackBehavior = new DistractEnemy();
            SecondaryAttackBehavior = new VerbalAssault();
            DefendBehavior = new Block();
        }
    }
}