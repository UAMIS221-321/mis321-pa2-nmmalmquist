

using System;

namespace source.classes.models
{
    public class Player
    {
        public string Name { get; set; }
        public Character CharacterSelection { get; set; }

        public Player(int playerIndex)
        {
            Console.WriteLine($"Player {playerIndex}, please insert your name");
            Name = Console.ReadLine();
            Console.Clear();
            CharacterSelection = ChooseACharacter();
             
        }
        public Character ChooseACharacter()
        {
            Character[] characterList = Character.GetCharacterList();
            Console.WriteLine($"{Name}, please choose your character. Select the Id of the character");
            for (int i = 0; i < characterList.Length; i++)
            {
                Console.WriteLine($"{i + 1})  {characterList[i].Name}");
            }

            //return a 1-based index of the charcater in the character list the want, so must adjust the index by negative 1 to get the 0-based index.
            int characterIndex = GetCharacterSelection();
            return (Character)characterList[characterIndex - 1].Clone();;
        }
       

        public int GetCharacterSelection()
        {
            BasicUtility basicUtil = new BasicUtility();
            int userSelection = basicUtil.GetInt();

            while (true)
            {
                if (1 <= userSelection && userSelection <= Character.GetCharacterList().Length)
                {
                    return userSelection;
                }
                Console.WriteLine("You did not enter a valid character Id. Try Again!");
                userSelection = basicUtil.GetInt();
            }
        }

        public override string ToString()
        {
            return Name + ": " + CharacterSelection.Name;
        }
    }
}