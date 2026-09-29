using System;
using System.Collections.Generic;
using System.Text;


namespace Tågäventyret
{
    public class Mutant : Zombie
    {
        public bool HasTrainKey { get; private set; } = true;

        public Mutant()
            : base("Zombie Captain", hp: 30, attack: 10,forsvar:8, xpBeloning: 50)
        {
        }
    }
}
