using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.IO;

namespace ThePorcelainDoll
{
    class Player
    {
        public string? Name { get; set; }   //Gets the name of the player the "?" after the string key word allows for this to be nullable
        public int health = 25;             //sets the player health to 25 this may very well change later
        public int cash = 500;              //sets the cash
        public int damage = 10;             //sets the damage
        public int elixir = 5;              //sets the amount of elixirs the player has
        public string? gender;              //sets the gender of the player
    }
}
