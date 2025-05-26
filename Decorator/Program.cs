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
            var creature = new BaseCreature();
            Console.WriteLine("=== CREATURE ABILITIES ===");
            Console.WriteLine(creature.GetAbility());
            Console.WriteLine();

            Console.WriteLine("=== CREATURE ABILITIES ===");
            FlyingDecorator flyingCreature = new FlyingDecorator(creature);
            Console.WriteLine(flyingCreature.GetAbility());
            Console.WriteLine();

            Console.WriteLine("=== CREATURE ABILITIES ===");
            TrampleDecorator trampleCreature = new TrampleDecorator(flyingCreature);
            Console.WriteLine(trampleCreature.GetAbility());
            Console.WriteLine();
        }
    }
}
