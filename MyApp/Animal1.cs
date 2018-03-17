using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmClass
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public int NumberOfLegs { get; set; }
        public int NumberOfEars { get; set; }


        public Animal()
        {
            this.Name = Name;
            this.Age = Age;
            this.Color = Color;
            this.NumberOfEars = NumberOfEars;
            this.NumberOfLegs = NumberOfLegs;  
        }


        public virtual void AnimalMove()
        {
            Console.WriteLine();
        }
        public virtual void AnimalSound()
        {
            Console.WriteLine();
        }
        public virtual void Eat()
        {
            Console.WriteLine("The animal is eating!");
        }
        public virtual void Resource()
        {
            Console.WriteLine("The animal produce a product");
        }
        

    }
}
