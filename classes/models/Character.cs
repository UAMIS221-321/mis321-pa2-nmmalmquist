using source.interfaces;
using source.classes.models.character_types;

namespace source.classes.models
{
    public abstract class Character
    {
        private static Character[] characterList = {new JackSparrow(), new WillTurner(), new DavyJones()};

        public static Character[] GetCharacterList()
        {
            return characterList;   
        }
        
        public string Name { get; set; }
        public double MaxPower { get; set; }
        public double MaxDefense { get; set; }
        public double Health { get; set; }
        public IPrimaryAttack PrimaryAttackBehavior { get; set; }
        public ISecondaryAttack SecondaryAttackBehavior { get; set; }
        public IDefend DefendBehavior { get; set; }

        public object Clone(){
           return this.MemberwiseClone();
        }
    }
}