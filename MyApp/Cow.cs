using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmClass
{
    class Cow : Animal
    {
      

        public override void AnimalMove()
        {
            Console.WriteLine($" The Cow is moving very slow!");
            base.AnimalMove();
            return;
        }
        public override void AnimalSound()
        {
            Console.WriteLine(" Moo!");
            base.AnimalSound();
        }
        public override void Eat()
        {
            Console.WriteLine("The Cow is eating grass!");
            base.Eat();
        }
        public override void Resource()
        {
            Console.WriteLine($"The Cow provide Beef and Milk as a resource!");
            base.Resource();
        }
        

    }
}
