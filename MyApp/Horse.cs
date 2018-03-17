using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmClass
{
    class Horse : Animal
    {


        public override void AnimalMove()
        {
            Console.WriteLine($" The Horse is running!");
            base.AnimalMove();
        }
        public override void AnimalSound()
        {
            Console.WriteLine(" The horse said, \"Bla! Bla!\"");
            base.AnimalSound();
        }
        public override void Eat()
        {
            Console.WriteLine("The Horse is eating hay!");
            base.Eat();
        }
        public override void Resource()
        {
            Console.WriteLine($"The Horse provide transportion as a resource!");
            base.Resource();
        }

    }
}
