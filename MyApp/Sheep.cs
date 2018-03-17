using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmClass
{
    class Sheep : Animal
    {

        public override void AnimalMove()
        {
            Console.WriteLine($" The Sheep is moving very slow!");
            base.AnimalMove();
        }
        public override void AnimalSound()
        {
            Console.WriteLine(" The Sheep said,\"Baaaa!\"");
            base.AnimalSound();
        }
        public override void Eat()
        {
            Console.WriteLine("The Sheep is eating food!");
            base.Eat();
        }
        public override void Resource()
        {
            Console.WriteLine($"The Sheep provide wool as a resource!");
            base.Resource();
        }
    }
}
