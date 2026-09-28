// Zombie attackerar spelaren
// Zombie attackerar spelaren
// Tre subklasser som ärver från monster
// Walker
// Runner 
// Mutant 
namespace Tågäventyret.Monster
{
    // 1. Carriage 1: Weakest Zombie- Walker

    public class Walker : Monster
    {
        public Walker()
             : base("Infected Passenger", health: 30, damage: 8, xpReward: 20, goldReward: 10)
        {
        }
    }

}