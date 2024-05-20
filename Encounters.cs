using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePorcelainDoll
{
    class Encounters
    {
        //This is were you will encounter enemies as you walk through the mansion
        //Generic

        public static void firstEncounter()
        {
            Console.WriteLine($"You are taken to a big metal door. The door is plain which contrasts with the rest of the house so far.\n" +
                $"The butler inserts a key and gently turns the locking mechanism inside the lock. You are suddenly filled with a rush \n" +
                $"of fear as the door hinges creak loudly. You flash a glance toward the butler whose face remains emotionless as he \n" +
                $"motions for you to enter the room. You are suddenly face with options.");
            Console.WriteLine($"1.) You can enter the room not knowing what awaits you.\n" +
                $"2.) You can run heading back the way you came.\n" +
                $"3.) You can stand there waiting for the butler to do something else.");
        }

        //Encounter Handlers
        public static void Fighting(bool random, string name, int power, int health)
        {
            string encounterEnemy = "";         //This is the enemies name
            int encounterPower = 0;             //This is the enemies power or strength
            int encounterHealth = 0;            //This is the enemies health

            if(random)
            {

            }
            else
            {
                encounterEnemy = name;
                encounterPower = power;
                encounterHealth = health;
            }

            while(health > 0)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("|   Attack    Defend    |");
                Console.WriteLine("|         Run           |");
                Console.WriteLine($"|Elixirs: {Program.currentPlayer.elixir}             |");
                Console.WriteLine($"|Health: {Program.currentPlayer.health}           |");
                Console.WriteLine("-------------------------");
                string temp = Console.ReadLine();

                if(temp.ToLower() == "a" || temp.ToLower() == "attack")
                {
                    //Attack
                }
                else if (temp.ToLower() == "d" || temp.ToLower() == "defend")
                {
                    //Just stand there
                }
                else if(temp.ToLower() == "r" || temp.ToLower() == "run")
                {
                    //Run back to the front door
                }
            }
        }
    }
}
