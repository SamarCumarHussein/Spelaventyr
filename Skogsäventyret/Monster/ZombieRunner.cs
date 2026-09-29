using System;
using System.Collections.Generic;
using System.Text;
// 2. Carriage 2: Medium Zombie - Runner

namespace Tågäventyret.Monster
{
    public class Runner : Zombie
    {
        public Runner()
           : base("Mutated Guard", hp: 60, attack: 15,forsvar: 2, xpBeloning: 50)
        {
        }
    }
}
