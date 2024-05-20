using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ThePorcelainDoll
{
    class Program
    {
        public static Player currentPlayer = new Player();

        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Console.WriteLine("The Porcelain Doll");
            Console.WriteLine($"You are greeted by a tall, thin man in a tuxedo. 'Good Day.' His voice gives you the sense of walking on gravel. \n" +
                $"The man bows low to you and then straighens himself again. 'If you would follow me. What might your name be?' \n" +
                $"He pauses long enough for you to answer.");
            Console.WriteLine("What gender are you? Please type Male or Female.");
            currentPlayer.gender = Console.ReadLine();

            if (currentPlayer.gender == "Male")
            {
                currentPlayer.gender = "Mister";
            }
            else if (currentPlayer.gender == "Female")
            {
                currentPlayer.gender = "Madam";
            }
            else
            {
                Console.WriteLine($"The man regards you distainfully 'You are one of those people are you?'");                
            }

            Console.WriteLine($"And your name {currentPlayer.gender}?");
            currentPlayer.Name = Console.ReadLine();
            Console.WriteLine($"{currentPlayer.gender} {currentPlayer.Name} follow me.");
            Console.WriteLine($"You suddenly don't remember how you got in front of this man nor do you remember how you got here.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"The man's footsteps echo through the foyer as he methodically walks toward the big staircase in front of you. \n" +
                $"It is only now that you notice that everything around you is clean and brightly colored. As the sun sets behind you the \n" +
                $"light dances off the crystal chandelier, sending a rainbow of muted colors dancing on the bright elegant walls. The wide open foyer \n" +
                $"gives you a sense of a massive cavern that opened up after you stepped inside. On you left you see a hallway strech out before you \n" +
                $"that is almost as equally vast as the foyer. You can see the elegant door frames lining the hallway though every door is shut. \n");
            Console.WriteLine($"To your right there is a thick heavy wooden door that is closed. The door is carved with figures that you have never seen \n" +
                $"before. You can also hear faint voices coming from the door though you can not make out what is being said. 'Shall we {currentPlayer.gender} {currentPlayer.Name}'\n" +
                $"The butler's voice breaks your concentration as you follow him up the stairs.");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadKey();
            Console.Clear();
            
        }
    }
}