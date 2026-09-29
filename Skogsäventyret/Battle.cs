using System;

namespace Tågäventyret;

public class Battle
{

    public void StartBattle(Player player, Zombie zombie)
    {
        Console.WriteLine($"You meet {zombie.Name}!");

        while (player.Hp > 0 && zombie.Hp > 0 )
        {
            Console.WriteLine();
            Console.WriteLine($"Your hp: {player.Hp}");
            Console.WriteLine($"{zombie.Name} HP: {zombie.Hp}");
            
            Console.WriteLine("\nWhat do you want to do?");
            Console.WriteLine("1. Defend");
            Console.WriteLine("2. Attack");
            Console.WriteLine("3. Run");
            
            string choice = Console.ReadLine();

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
        }

        if (zombie.Hp < 0)
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
        int damage = zombie.Attack / 2;
        player.TakeDamage(damage);
        
        Console.WriteLine($"You defend yourself and take {damage} damage.");
        
    }

    private void Attack(Player player, Zombie zombie)
    {
        int damage = player.Attack;

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

        int damage = random.Next(1, zombie.Attack + 1);
        player.TakeDamage(damage);

        Console.WriteLine($"You try to run and take {damage} damage!");

    }




}



