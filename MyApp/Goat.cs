using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FarmClass
{
    class Goat : Animal
    {
        public override void AnimalMove()
        {
            Console.WriteLine($" The Goat is moving very slow!");
            base.AnimalMove();
        }
        public override void AnimalSound()
        {
            Console.WriteLine(" The goat said, \"Hello!\"");
            base.AnimalSound();
        }
        public override void Eat()
        {
            Console.WriteLine("The Goat is eating grass!");
            base.Eat();
        }
        public override void Resource()
        {
            Console.WriteLine($"The Goat provide Goat meat as a resource!");
            base.Resource();
        }
    }
}
