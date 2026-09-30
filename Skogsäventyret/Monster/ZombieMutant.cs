using System;
using System.Collections.Generic;
using System.Text;


namespace Tågäventyret
{
    public class Mutant : Zombie
    {
        public bool HasTrainKey { get; private set; } = true;

        public Mutant()
<<<<<<< HEAD
            : base("Zombie Captain", hp: 50, attack: 12,forsvar:5, xpBeloning: 50)
=======
            : base("Zombie Captain", hp: 30, attack: 10,forsvar:8, xpBeloning: 50)
>>>>>>> 8e07cb0ef57a8c92bcf7cf84366a2c540a7a7cf1
        {
        }
    }
}
