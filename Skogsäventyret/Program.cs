using System;
using Tågäventyret.Monster;



namespace Tågäventyret;

public class Battle
{

    public void StartBattle(Player player, Monster monster)
    {
        Console.WriteLine($"You meet {monster.Name}!");

        while (player.Hp > 0 && !monster.IsDead())
        {
            Console.WriteLine();
            Console.WriteLine($"Your hp: {player.Hp}");
            Console.WriteLine($"{monster.Name} HP: {monster.Health}");
            
            Console.WriteLine("\nWhat do you want to do?");
            Console.WriteLine("1. Defend");
            Console.WriteLine("2. Attack");
            Console.WriteLine("3. Run");
            
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Defend(player, monster);
            }
            else if (choice == "2")
            {
                Attack(player, monster);
            }
            else if (choice == "3")
            {
                Run(player, monster);
            }
            else
            {
                Console.WriteLine("Invalid choice. Choose 1, 2 or 3.");
            }
        }

        if (monster.IsDead())
        {
            Console.WriteLine($"You defeated {monster.Name}!");
            player.GainXP(monster.XpReward);
        }
        else
        {
            Console.WriteLine("You died!");
        }
    }

    private void Defend(Player player, Monster monster)
    {
        int damage = monster.Damage / 2;
        player.TakeDamage(damage);
        
        Console.WriteLine($"You defend yourself and take {damage} damage.");
        
    }

    private void Attack(Player player, Monster monster)
    {
        int damage = player.Attack;

        if (damage < 1)
        {
            damage = 1;
        }    
        
        monster.TakeDamage(damage);
        Console.WriteLine($"You attack and deal {damage} damage!");
        
    }

    private void Run(Player player, Monster monster)
    {
        Random random = new Random();

        int damage = random.Next(1, monster.Damage + 1);
        player.TakeDamage(damage);

        Console.WriteLine($"You try to run and take {damage} damage!");

    }




}



