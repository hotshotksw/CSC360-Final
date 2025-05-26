using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class TrampleDecorator : Decorator
    {
        public TrampleDecorator(Creature component) : base(component)
        {
            this.ability = "TRAMPLE";
        }

        public override string GetAbility()
        {
            return base.GetAbility();
        }
    }
}
