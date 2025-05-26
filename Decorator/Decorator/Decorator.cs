using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Decorator : Ability
    {
        protected Ability _ability;

        public Decorator(Ability component)
        {
            this._ability = component;
        }

        public void SetComponent(Ability component)
        {
            this._ability = component;
        }

        public override string Operation()
        {
            if (this._ability != null)
            {
                return this._ability.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
