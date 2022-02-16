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
        public double GetDouble()
        {
            string userInput = Console.ReadLine();
            double userdouble;

            while (!double.TryParse(userInput, out userdouble))
            {
                Console.WriteLine("I am sorry, that is not an number. Please enter a number.");
                userInput = Console.ReadLine();
            }

            return userdouble;
        }
        public bool GetBool()
        {
            string userInput = Console.ReadLine()[0].ToString().ToLower();

            while (userInput!= "n" && userInput != "y")
            {
                Console.WriteLine("I am sorry, that is not an valid boolean. Please enter either yes or no.");
                userInput = Console.ReadLine()[0].ToString().ToLower();
            }
            if (userInput == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public string BoolToYesNo(bool thisbool)
        {
            if(thisbool == true)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
        public string GetBoolString()
        {
            string userInput = Console.ReadLine()[0].ToString().ToLower();

            while (userInput!= "n" && userInput != "y" && userInput != "")
            {
                Console.WriteLine("I am sorry, that is not an valid boolean. Please enter either yes or no.");
                userInput = Console.ReadLine()[0].ToString().ToLower();
            }
            if (userInput == "y")
            {
                return "1";
            }
            else if(userInput == "n")
            {
                return "0";
            }
            else
            {
                return "";
            }
            
        }
        public DateTime GetDateTime()
        {
            string userInput = Console.ReadLine();
            DateTime userDateTime;

            while (!DateTime.TryParse(userInput, out userDateTime))
            {
                Console.WriteLine("I am sorry, that is not an valid Date. Please enter an Date value.");
                userInput = Console.ReadLine();
            }

            return userDateTime;
        }

        public bool AskUserToKeepLooping()
        {
            string userInput = Console.ReadLine();
            while(userInput == "" || userInput == " ")
            {
                Console.WriteLine("That is not a valid repsonce. Try again...");
                userInput = Console.ReadLine();
            }
            while (userInput[0].ToString().ToLower() != "n" && userInput[0].ToString().ToLower() != "y")
            {
                Console.WriteLine("That is not a valid repsonce. Try again...");
                userInput = Console.ReadLine();
            }
            if(userInput[0].ToString().ToLower() == "n")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int GetRating()
        {
            int userInt = GetInt();

            while (!(userInt >= 1) || !(userInt <= 5) )
            {
                Console.WriteLine("I am sorry, that is not an integer. Please enter an integer value.");
                userInt = GetInt();
            }

            return userInt;
        }
    }
}