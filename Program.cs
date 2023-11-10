namespace pa5dwelchel
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Player 1, enter your name:");
            string player1Name = Console.ReadLine();
            Console.WriteLine("Player 2, enter your name:");
            string player2Name = Console.ReadLine();

            // players choose their characters
            var player1 = ChooseCharacter(player1Name);
            var player2 = ChooseCharacter(player2Name);

            // Who attacks first
            bool player1AttacksFirst = new Random().Next(2) == 0;

            // Gameplay
            while (player1.Health > 0 && player2.Health > 0)
            {
                if (player1AttacksFirst)
                {
                    PlayerTurn(player1, player2);
                }
                else
                {
                    PlayerTurn(player2, player1);
                }

                player1AttacksFirst = !player1AttacksFirst;
            }

    // determines winner
            string winnerName = player1.Health > 0 ? player1.Name : player2.Name;
            Console.WriteLine($"Game over! {winnerName} is the winner!");
        }

        static Character ChooseCharacter(string playerName)
        {
            Console.WriteLine($"{playerName}, choose your character:");
            Console.WriteLine("1. Mario");
            Console.WriteLine("2. Bowser");
            Console.WriteLine("3. DK");

            int choice;
            do
            {
                Console.Write("Enter your choice (1, 2, or 3): ");
            } while (!int.TryParse(Console.ReadLine(), out choice) || (choice < 1 || choice > 3));

            switch (choice)
            {
                case 1:
                    return new Mario(playerName);
                case 2:
                    return new Bowser(playerName);
                case 3:
                    return new DK(playerName);
                default:
                    throw new InvalidOperationException("Invalid character choice");
            }
        }

        static void PlayerTurn(Character attacker, Character defender)
        {
            Console.WriteLine($"{attacker.Name}'s turn:");

            // choose attack or defense
            Console.WriteLine("Choose your action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");

            int choice;
            do
            {
                Console.Write("");
            } while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2));

            if (choice == 1)
            {
                
                attacker.Attack(defender);
            }
            else
            {
                defender.Defend(attacker.AtkPwr);
                Console.WriteLine($"{attacker.Name} chose to defend!");
            }
            
            defender.DisplayStats();
        }
    }
}