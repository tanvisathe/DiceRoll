using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int min = 1;
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Welcome to Grand Circus Casino! Roll the dice? (y/n)");
                string answer = Console.ReadLine();
                answer = answer.ToLower().Trim();

                if (answer == "y")
                {
                    Console.WriteLine("How many sides should each die have?");
                    var dieSides = Console.ReadLine();
                                    
                   bool validationStatus = UserInputValidation(dieSides);

                    if (validationStatus == true)
                    {
                        var die1Side = int.Parse(dieSides);
                        die1Side = die1Side + 1;  // Adding 1 since Max value in Random class is not inclusive
                                  
                        // Creating Dice class object            
                        Dice die1 = new Dice();
                       
                        //Calling method RollDice to get random numbers for pair of dice
                        int diceroll1 = die1.RollDice(min, die1Side,r);
                        int diceroll2 = die1.RollDice(min, die1Side, r);

                        //Calling Methods with Special Messages
                        die1.SnakeEyes(diceroll1, diceroll2);
                        die1.Craps(diceroll1, diceroll2);
                        die1.BoxCars(diceroll1, diceroll2);
                    }
                }
                run = Continue();
            }
        }
      
        public static bool UserInputValidation(string _dice1Sides)
        {
            int value;

            try
            {
                int dice1Sides = Convert.ToInt32(_dice1Sides);
               
                if (string.IsNullOrWhiteSpace(_dice1Sides) || string.IsNullOrWhiteSpace(_dice1Sides))
                {
                    Console.WriteLine("Please enter valid numbers for the Dice Roll.");
                    return false;
                }
                else if (!Int32.TryParse(_dice1Sides, out value))
                {
                    Console.WriteLine("Please enter Non-Zero and Positive numbers as input and try again.");
                    return false;
                }
                else if (value == 0)
                {
                    Console.WriteLine("Dice cannot have zero sides, please try again. ");

                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()} means  {ex.Message}");                
                return false;                
            }
        }

        public static bool Continue()
        {
                Console.WriteLine("Do you want to continue?(y/n)");
                string input = Console.ReadLine();
                input = input.ToLower();
                bool goAhead;
                if (input == "y")
                {
                    goAhead = true;

                }
                else if (input == "n")
                {
                    goAhead = false;
                }
                else
                {
                    Console.WriteLine("I don't understand that, please try again");
                    goAhead = Continue();
                }
                return goAhead;
        }
    }
}
