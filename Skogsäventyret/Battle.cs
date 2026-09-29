namespace Tågäventyret;

public class Battle
{
    // Startar och fortsätter striden så länge både spelaren och zombien lever
    public void StartBattle(Player player, Zombie zombie)
    {
        Console.WriteLine($"You meet {zombie.Name}!");

        while (player.Hp > 0 && zombie.Hp > 0 )
        {
            Console.WriteLine();
            
            Console.WriteLine("\nWhat do you want to do?");
            Console.WriteLine("1. Defend");
            Console.WriteLine("2. Attack");
            Console.WriteLine("3. Run");
            
            string choice = Console.ReadLine();
            // Spelarens val avgör vilken handling som utförs under rundan
            if (choice == "1")
            {
                Defend(player, zombie);
            }
            else if (choice == "2")
            {
                Attack(player, zombie);
            }
            else if (choice == "3")
            {
                Run(player, zombie);
            }
            else
            {
                Console.WriteLine("Invalid choice. Choose 1, 2 or 3.");
            }
            // Visar resultatet efter varje runda så spelaren kan följa bådas HP
            Console.WriteLine($"Your HP: {player.Hp}");
            Console.WriteLine($"{zombie.Name} HP: {zombie.Hp}");
        }
        // XP ges endast om spelaren lyckades besegra zombien
        if (zombie.Hp <= 0)
        {
            Console.WriteLine($"You defeated {zombie.Name}!");
            player.GainXP(zombie.XpBeloning);
        }
        else
        {
            Console.WriteLine("You died!");
        }
    }

    private void Defend(Player player, Zombie zombie)
    {
        // Försvar halverar skadan från zombiens attack
        int damage = zombie.Attack / 2;
        player.TakeDamage(damage);
        
        Console.WriteLine($"You defend yourself and take {damage} damage.");
        
    }

    private void Attack(Player player, Zombie zombie)
    {
        // Zombiens försvar minskar spelarens attackskada
        int damage = player.Attack - zombie.Forsvar;
        
        // Minst 1 skada görs så att en attack alltid kan skada zombien
        if (damage < 1)
        {
            damage = 1;
        }    
        
        zombie.TakeDamage(damage);
        Console.WriteLine($"You attack and deal {damage} damage!");
        
    }

    private void Run(Player player, Zombie zombie)
    {
        Random random = new Random();

        // Flykt ger slumpmässig skada upp till zombiens attackvärd
        int damage = random.Next(1, zombie.Attack + 1);
        player.TakeDamage(damage);

        Console.WriteLine($"You try to run and take {damage} damage!");

    }




}



