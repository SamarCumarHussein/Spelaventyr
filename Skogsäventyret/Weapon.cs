
namespace Tågäventyret;

public class Monster
{
    public string Name { get; protected set; }
    public int Health { get; protected set; }
    public int Damage { get; protected set; }
    public int XpReward { get; protected set; }
    public int GoldReward { get; protected set; }

    public Monster(string name, int health, int damage, int xpReward, int goldReward)
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

// 1. Carriage 1: Weakest Zombie
public class WeakZombie : Monster
{
    public WeakZombie()
        : base("Infected Passenger", health: 30, damage: 8, xpReward: 20, goldReward: 10)
    {
    }
}

// 2. Carriage 2: Medium Zombie
public class MediumZombie : Monster
{
    public MediumZombie()
        : base("Mutated Guard", health: 60, damage: 15, xpReward: 50, goldReward: 30)
    {
    }
}

// 3. Final Carriage: Big Boss
public class BossZombie : Monster
{
    public bool HasTrainKey { get; private set; } = true;

    public BossZombie()
        : base("Zombie Captain", health: 120, damage: 25, xpReward: 100, goldReward: 100)
    {
    }
}
