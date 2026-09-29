using System;
using System.Collections.Generic;
using System.Text;


namespace Tågäventyret
{
    public class Mutant : Zombie
    {
        public bool HasTrainKey { get; private set; } = true;

        public Mutant()
            : base("Zombie Captain", hp: 50, attack: 12,forsvar:5, xpBeloning: 50)
        {
        }
    }
}
