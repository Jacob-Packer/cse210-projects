class Game
{
    public void Run()
    {
        Console.WriteLine("Welcome to Duck Hero Adventure!");
        Console.CursorLeft = Console.BufferWidth - 5;
        Console.Write("(-^-)");
        
        Console.WriteLine("Press any key to start the fight...");
        Console.ReadKey();
        
        // Initialize player and enemy stats
        Duck duck = new Duck();
        Hunter hunter = new Hunter();

        int playerHealth = duck.GetHealth();
        int enemyHealth = hunter.GetHealth();

        // random object
        Random rnd = new Random();

        // menu object
        Menu menu = new Menu();

        // animation object
        GameAnimation gameAnimation = new GameAnimation();

        // Main game loop
        while (playerHealth > 0 && enemyHealth > 0)
        {
            //Write menu options
            Console.Clear();
            Console.WriteLine($"Player Health: {playerHealth}  Enemy Health: {enemyHealth}");
            Console.WriteLine("Choose your move:");
            menu.DisplayMenu();
            gameAnimation.DisplayBattlefield();
            
            // Get player's move
            char playerMove = Console.ReadKey().KeyChar;
            Console.WriteLine();
            
            // Get enemy's move (random for simplicity)
            char enemyMove = rnd.Next(1, 3).ToString()[0];
            
            // Resolve moves
            if (playerMove == '1') // Attack
            {
                int playerAttack = rnd.Next(duck.GetAttackLow(), duck.GetAttackHigh());
                Console.WriteLine($"You attack the hunter for {playerAttack} damage!");
                enemyHealth -= playerAttack;
            }
            else if (playerMove == '2') // Defend
            {
                Console.WriteLine("You brace for impact!");
                playerHealth += 5;
            }
            
            if (enemyMove == '1') // Hunter attacks
            {
                int enemyAttack = rnd.Next(hunter.GetAttackLow(), hunter.GetAttackHigh());
                Console.WriteLine($"The hunter attacks you for {enemyAttack} damage!");
                playerHealth -= enemyAttack;
            }
            else if (enemyMove == '2') // Hunter defends
            {
                Console.WriteLine("The hunter braces for impact!");
                enemyHealth += 5;
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
            Console.WriteLine("Congratulations! You have defeated the hunter and saved the prisoner duck!");
            gameAnimation.SaveDuckAnimation();
        }
        Console.Write("Press any key to end the game. (Press [B] to enter BOSS FIGHT.)");
        char choice = Console.ReadKey().KeyChar;
        
        
        //Easter egg boss fight
        if (choice == 'b')
        {
        Console.Clear();
        Console.WriteLine("Welcome to the Hidden SUPER BOSS Fight!");
        Console.CursorLeft = Console.BufferWidth - 5;
        Console.Write("(\\./)");
        
        Console.WriteLine("Press any key to start the fight...");
        Console.ReadKey();
        
        // Initialize player and enemy stats
        Boss boss = new Boss();

        int bossHealth = boss.GetHealth();

        // Main game loop
        while (playerHealth > 0 && bossHealth > 0)
        {
            //Write menu options
            Console.Clear();
            Console.WriteLine($"Player Health: {playerHealth}  SUPER BOSS Health: {bossHealth}");
            Console.WriteLine("Choose your move:");
            menu.DisplayMenu();
            gameAnimation.DisplayBossBattlefield();
            
            // Get player's move
            char playerMove = Console.ReadKey().KeyChar;
            Console.WriteLine();
            
            // Get enemy's move (random for simplicity)
            char bossMove = rnd.Next(1, 3).ToString()[0];
            
            // Resolve moves
            if (playerMove == '1') // Attack
            {
                int playerAttack = rnd.Next(duck.GetAttackLow(), duck.GetAttackHigh());
                Console.WriteLine($"You attack the SUPER BOSS for {playerAttack} damage!");
                bossHealth -= playerAttack;
            }
            else if (playerMove == '2') // Defend
            {
                Console.WriteLine("You brace for impact!");
                playerHealth += 5;
            }
            
            if (bossMove == '1') // Hunter attacks
            {
                int bossAttack = rnd.Next(boss.GetAttackLow(), boss.GetAttackHigh());
                Console.WriteLine($"The SUPER BOSS attacks you for {bossAttack} damage!");
                playerHealth -= bossAttack;
            }
            else if (bossMove == '2') // Hunter defends
            {
                Console.WriteLine("The SUPER BOSS braces for impact!");
                enemyHealth += 5;
            }
            
            // Pause for a moment to let the player see what happened
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        
        // Determine the winner
        Console.Clear();
        if (playerHealth <= 0)
        {
            Console.WriteLine("You have been defeated! The SUPER BOSS eats you.");
        }
        else
        {
            Console.WriteLine("Congratulations! You have defeated the SUPER BOSS and saved the world!");
            gameAnimation.DefeatBossAnimation();
        }
 
        }
        
    }
}