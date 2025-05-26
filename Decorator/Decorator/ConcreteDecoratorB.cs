using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Ability component) : base(component)
        {
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorA({base.Operation()})";
        }
    }
}
