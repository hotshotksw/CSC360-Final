using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var baseAbility = new ConcreteAbility();
            Console.WriteLine();

            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(baseAbility);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
        }
    }
}
