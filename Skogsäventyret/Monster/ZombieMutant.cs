

namespace Tågäventyret
{
    public class Mutant : Zombie
    {
        public bool HasTrainKey { get; private set; } = true;

        public Mutant()

            : base("Zombie Captain", hp: 30, attack: 2,forsvar:2, xpBeloning: 50)
        {
        }
    }
}
