namespace Tågäventyret.Monster;
 // Zombie/monster är basklassen för alla fiender 
 // Genmensam logik placeras här så att basklassen kan anropa samma funktioner

public class Monster
{
    // Full properties används
    // get och protected set för Namn, Health, Damage,XpReward,GoldReward
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int Damage { get; private set; }
    public int XpReward { get; private set; }
    public int GoldReward { get; private set; }

    // Konatruktor

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




















