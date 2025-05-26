using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class BaseCreature : Creature
    {
        public override string GetAbility()
        {
            return "BASE";
        }
    }
}
