namespace Tågäventyret;
 // Zombie/monster är basklassen för alla fiender 
 // Genmensam logik placeras här så att basklassen kan anropa samma funktioner

public class Zombie
{
    // Full properties används
    // get och protected set för Namn, Health, Damage,XpReward,GoldReward
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int Damage { get; private set; }
    public int XpReward { get; private set; }
    public int GoldReward { get; private set; }

    // Konatruktor

    public Zombie(string name, int health, int damage, int xpReward, int goldReward)
    {
        Name = name;
        Health = health;
        Damage = damage;
        XpReward = xpReward;
        GoldReward = goldReward;
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
        if (Health < 0) Health = 0;
    }

    public bool IsDead()
    {
        return Health <= 0;
    }
}



// Tar skada från spelaren
// Minskar Zombies HP och returnera true om monstret dör











// Zombie attackerar spelaren


// Tre subklasser som ärver från monster
// Walker
// Runner 
// Mutant 
// 1. Carriage 1: Weakest Zombie- Walker

public class Walker: Zombie
{
    public Walker()
         : base("Infected Passenger", health: 30, damage: 8, xpReward: 20, goldReward: 10)
    {
    }
}
// 2. Carriage 2: Medium Zombie - Runner

public class Runner: Zombie
{
    public Runner()
       : base("Mutated Guard", health: 60, damage: 15, xpReward: 50, goldReward: 30)
    {
    }
}
// 3. Final Carriage: Big Boss

public class Mutant: Zombie
{
    public bool HasTrainKey { get; private set; } = true;

    public Mutant()
        : base("Zombie Captain", health: 120, damage: 25, xpReward: 100, goldReward: 100)
    {
    }
}