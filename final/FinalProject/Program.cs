using System;

class Program
{
    static void Main(string[] args)
    {
    //    get shield, get sword, get key
       
        Console.Clear();
        Game game = new Game();
        Console.WriteLine("Welcome to Duck Hero Adventure!\n");
        Console.WriteLine($"The duck {game.GetName()} has been captured. Go beat the hunter and free him!");
        Console.WriteLine("Press any key to start the fight...");
        Console.ReadKey();
        
        // Initialize player and enemy stats
        int playerHealth = 100;
        int enemyHealth = 100;
        Random rnd = new Random();
        
        // Main game loop
        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.Clear();
            Console.WriteLine($"Player Health: {playerHealth}  Enemy Health: {enemyHealth}");
            Console.WriteLine("Choose your move:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");
            game.DisplayBattlefield();
            
            // Get player's move
            char playerMove = Console.ReadKey().KeyChar;
            Console.WriteLine();
            
            // Get enemy's move (random for simplicity)
            char enemyMove = rnd.Next(1, 3).ToString()[0];
            
            // Resolve moves
            if (playerMove == '1') // Attack
            {
                int playerAttack = rnd.Next(10, 20);
                Console.WriteLine($"You attack the hunter for {playerAttack} damage!");
                enemyHealth -= playerAttack;
            }
            else if (playerMove == '2') // Defend
            {
                Console.WriteLine("You brace for impact!");
            }
            
            if (enemyMove == '1') // Hunter attacks
            {
                int enemyAttack = rnd.Next(8, 15);
                Console.WriteLine($"The hunter attacks you for {enemyAttack} damage!");
                playerHealth -= enemyAttack;
            }
            else if (enemyMove == '2') // Hunter defends
            {
                Console.WriteLine("The hunter braces for impact!");
            }
            
            // Pause for a moment to let the player see what happened
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        
        // Determine the winner
        Console.Clear();
        if (playerHealth <= 0)
        {
            Console.WriteLine("You have been defeated! The prisoner duck remains captive.");
        }
        else
        {
            Console.WriteLine("Congratulations! You have defeated the hunter and found the key!");
            game.DuckLeavingCageAnimation();
        }
    }
    
}

