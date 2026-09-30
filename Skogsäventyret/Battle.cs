using System;

namespace Tågäventyret;




public class Battle
{
    // Striden fortsätter tills spelaren eller monstret dör
    public void StartBattle(Player player, Zombie zombie)
    {
        Console.WriteLine($"Du möter {zombie.Name}!");

<<<<<<< HEAD
        while (player.Hp > 0 && !monster.IsDead())
        {
            Console.WriteLine();
            Console.WriteLine($"Your hp: {player.Hp}");
            Console.WriteLine($"{monster.Name} HP: {monster.Health}");
            
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Defend");
            Console.WriteLine("2. Attack");
            Console.WriteLine("3. Run");
            
            string choice = Console.ReadLine();
            // Spelarens val avgör vilken handling som utförs under rundan
=======
        while (player.Hp > 0 && zombie.Hp > 0)
        {
            Console.WriteLine();
            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("1. Försvara");
            Console.WriteLine("2. Anfalla");
            Console.WriteLine("3. Springa");

            // Spelaren väljer vad den vill göra
            string choice = Console.ReadLine() ?? "";

>>>>>>> 8e07cb0ef57a8c92bcf7cf84366a2c540a7a7cf1
            if (choice == "1")
            {
                Försvara(player, zombie);
            }
            else if (choice == "2")
            {
                Anfalla(player, zombie);
            }
            else if (choice == "3")
            {
                Springa(player, zombie);
            }
            else
            {
                Console.WriteLine("Fel val. Välj 1, 2 eller 3.");
                continue;
            }

            // Visar resultatet efter varje runda så spelaren kan följa bådas HP
            Console.WriteLine();
            Console.WriteLine($"Ditt HP: {player.Hp}");
            Console.WriteLine($"{zombie.Name} HP: {zombie.Hp}");
        }

        // Spelaren får XP när monstret besegras
        if (zombie.Hp <= 0)
        {
            Console.WriteLine();
            Console.WriteLine($"{zombie.Name} besegrades!");
            player.GainXP(zombie.XpBeloning);
        }
        else
        {
            // Spelet avslutas om spelaren dör
            Console.WriteLine();
            Console.WriteLine("Du dog!");
        }
    }

    // Försvar halverar monstrets skada
    private void Försvara(Player player, Zombie zombie)
    {
        int skada = zombie.Attack / 2;

        player.TakeDamage(skada);

        Console.WriteLine(
            $"Du försvarar dig. {zombie.Name} gör {skada} skada."
        );
    }

    // Spelarens attack minskas av monstrets försvar
    private void Anfalla(Player player, Zombie zombie)
    {
        int skada = player.Attack - zombie.Forsvar;

        // En attack gör alltid minst 1 skada
        if (skada < 1)
        {
            skada = 1;
        }

        zombie.TakeDamage(skada);

        Console.WriteLine(
            $"Du anfaller {zombie.Name} för {skada} skada."
        );

        // Monstret anfaller tillbaka om det fortfarande lever
        if (zombie.Hp > 0)
        {
            int monsterskada = zombie.Attack;

            player.TakeDamage(monsterskada);

            Console.WriteLine(
                $"{zombie.Name} anfaller dig för {monsterskada} skada."
            );
        }
    }

    // Springa ger slumpmässig skada mellan 1 och monstrets attack
    private void Springa(Player player, Zombie zombie)
    {
        Random random = new Random();

        int skada = random.Next(1, zombie.Attack + 1);

        player.TakeDamage(skada);

        Console.WriteLine(
            $"Du springer iväg men {zombie.Name} gör {skada} skada."
        );
    }
}
