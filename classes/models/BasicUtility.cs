using System;

namespace source.classes.models
{
    public class BasicUtility
    {
        public int GetInt()
        {
            string userInput = Console.ReadLine();
            int userInt;

            while (!int.TryParse(userInput, out userInt))
            {
                Console.WriteLine("I am sorry, that is not an integer. Please enter an integer value.");
                userInput = Console.ReadLine();
            }

            return userInt;
        }
        
    }
}