using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class FlyingDecorator : Decorator
    {
        public FlyingDecorator(Creature component) : base(component)
        {
            this.ability = "FLYING";
        }

        public override string GetAbility()
        {
            return base.GetAbility();
        }
    }
}
