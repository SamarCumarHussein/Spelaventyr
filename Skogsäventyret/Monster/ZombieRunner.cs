using System;
using System.Collections.Generic;
using System.Text;
// 2. Carriage 2: Medium Zombie - Runner

namespace Tågäventyret.Monster
{
    public class Runner : Monster
    {
        public Runner()
           : base("Mutated Guard", health: 60, damage: 15, xpReward: 50, goldReward: 30)
        {
        }
    }
}
