using System;
using System.Collections.Generic;
using System.Text;
// 3. Final Carriage: Big Boss

namespace Tågäventyret.Monster
{
    public class Mutant : Monster
    {
        public bool HasTrainKey { get; private set; } = true;

        public Mutant()
            : base("Zombie Captain", health: 120, damage: 25, xpReward: 100, goldReward: 100)
        {
        }
    }
}
