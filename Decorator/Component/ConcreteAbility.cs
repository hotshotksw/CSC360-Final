using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ConcreteAbility : Ability
    {
        public string ability;
        
        public override string Operation()
        {
            return "ABILITY: " + ability + "\n";
        }
    }
}
