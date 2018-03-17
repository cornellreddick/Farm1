using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmClass
{
    class Chickens : Animal
    {
        public override void AnimalMove()
        {
            Console.WriteLine($" The Chicken is running around in circles!");
            base.AnimalMove();
        }
        public override void AnimalSound()
        {
            Console.WriteLine(" The Chicken said, \"Cluck\"");
            base.AnimalSound();
        }
        public override void Eat()
        {
            Console.WriteLine("The Chicken is eating Chicken!");
            base.Eat();
        }
        public override void Resource()
        {
            Console.WriteLine($"The Chicken provide eggs and chicken meat as a resource!");
            base.Resource();
        }
    }
}
