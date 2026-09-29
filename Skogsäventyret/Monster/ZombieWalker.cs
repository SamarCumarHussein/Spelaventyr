// Zombie attackerar spelaren
// Tre subklasser som ärver från monster
// Walker
// Runner 
// Mutant 
namespace Tågäventyret
{
    // 1. Carriage 1: Weakest Zombie- Walker

    public class Walker : Zombie
    {
        public Walker()
             : base("Infected Passenger", hp: 30, attack: 8,forsvar: 5, xpBeloning: 20)
        {
        }
    }

}