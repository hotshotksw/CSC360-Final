using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Decorator : Creature
    {
        protected Creature _character;
        public string ability = "";

        public Decorator(Creature character)
        {
            this._character = character;
        }

        public void SetCreature(Creature character)
        {
            this._character = character;
        }

        public override string GetAbility()
        {
            if (this._character != null)
            {
                return this._character.GetAbility() + "\n" + ability;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
