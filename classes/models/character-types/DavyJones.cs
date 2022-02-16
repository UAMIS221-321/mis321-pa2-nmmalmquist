using source.classes.models;
using source.classes.behaviors;

namespace source.classes.models.character_types
{
    public class DavyJones: Character
    {
        public DavyJones()
        {
            Name = "Davy Jones";
            Health = 100;
            MaxDefense = 24;
            MaxPower = 40;
            PrimaryAttackBehavior = new CannnonFireAttack();
            SecondaryAttackBehavior = new TenticleWrapAttack();
            DefendBehavior = new Block();
        }
    }
}