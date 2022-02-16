using source.classes.models;
using source.classes.behaviors;


namespace source.classes.models.character_types
{
    public class DirtyDanny: Character
    {
        public DirtyDanny()
        {
            Name = "Dirty Dan";
            Health = 100;
            MaxDefense = 50;
            MaxPower = 75;
            PrimaryAttackBehavior = new DirtyBombAttack();
            SecondaryAttackBehavior = new FecesThrowAttack();
            DefendBehavior = new Block();
        }
    }
}