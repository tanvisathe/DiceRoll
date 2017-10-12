using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    public class Dice
    {
        public int RollDice(int min, int max, Random r)
        {
            int randomDiceRoll = r.Next(min, max);
            Console.WriteLine($"You Rolled: {randomDiceRoll}");
            return randomDiceRoll;
        }

        public void BoxCars(int roll1, int roll2)
        {
            if (roll1 == 6 && roll2 == 6)
            {
                Console.WriteLine("You rolled BoxCars!!");
            }
        }


        public void SnakeEyes(int roll1, int roll2)
        {
            if (roll1 == 1 && roll2 == 1)
            {
                Console.WriteLine("You Rolled Snake Eyes!!");
               
            }
            
        }

        public void Craps(int roll1, int roll2)
        {                      
                int sumRoll = roll1 + roll2;
                if (sumRoll == 2 || sumRoll == 3 || sumRoll == 13)
                {
                    Console.WriteLine("You Rolled Craps!!");
                }
            
        }

        
    }

}
