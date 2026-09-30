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
<<<<<<< HEAD
             : base("Infected Passenger", hp: 20, attack: 5,forsvar: 2, xpBeloning: 20)
=======
             : base("Infected Passenger", hp: 60, attack: 20,forsvar: 5, xpBeloning: 150)
>>>>>>> 8e07cb0ef57a8c92bcf7cf84366a2c540a7a7cf1
        {
        }
    }

}