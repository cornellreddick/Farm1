using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FarmClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the Reddick's Farm and we have the following animals. ");
            Console.WriteLine("===============================================================");

            Cow cow1 = new Cow();
            cow1.Name = "Boo! Boo!";
            cow1.Age = 20;
            cow1.Color = "Black and White";
            cow1.NumberOfEars = 2;
            cow1.NumberOfLegs = 4;

            Console.WriteLine($" A Cow name is: {cow1.Name}\n The Cow Age is: {cow1.Age}\n The Cow Color is: " +
                $"{cow1.Color}\n The Cow has {cow1.NumberOfEars} Ears and {cow1.NumberOfLegs} legs.");
            cow1.AnimalMove();
            cow1.AnimalSound();

            Sheep sheep1 = new Sheep();
            sheep1.Name = "Freddie";
            sheep1.Age = 3;
            sheep1.Color = "White";
            sheep1.NumberOfEars = 2;
            sheep1.NumberOfLegs = 4;

            Console.WriteLine($" A Sheep name is: {sheep1.Name}\n The Sheep Age is: {sheep1.Age}\n The Sheep Color is: " +
                 $"{sheep1.Color}\n The Sheep has {sheep1.NumberOfEars} Ears and {sheep1.NumberOfLegs} legs.");
            sheep1.AnimalMove();
            sheep1.AnimalSound();


            Chickens chicken1 = new Chickens();
            chicken1.Name = "Boo! Boo!";
            chicken1.Age = 1;
            chicken1.Color = "Yellow";
            chicken1.NumberOfEars = 0;
            chicken1.NumberOfLegs = 2;

            Console.WriteLine($" A Chicken name is: {chicken1.Name}\n The Chicken Age is: {chicken1.Age}\n The Chicken Color is: " +
                $"{chicken1.Color}\n The Chicken has {chicken1.NumberOfEars} Ears and {chicken1.NumberOfLegs} legs.");
            chicken1.AnimalMove();
            chicken1.AnimalSound();


            Goat goat1 = new Goat();
            goat1.Name = "Boo! Boo!";
            goat1.Age = 5;
            goat1.Color = "Gray";
            goat1.NumberOfEars = 2;
            goat1.NumberOfLegs = 4;

            Console.WriteLine($" A Goat name is: {goat1.Name}\n The Goat Age is: {goat1.Age}\n The Goat Color is: " +
                $"{goat1.Color}\n The Goat has {goat1.NumberOfEars} Ears and {goat1.NumberOfLegs} legs.");
            goat1.AnimalMove();
            goat1.AnimalSound();

            Horse horse1 = new Horse();
            horse1.Name = "Boo! Boo!";
            horse1.Age = 6;
            horse1.Color = "Brown";
            horse1.NumberOfEars = 2;
            horse1.NumberOfLegs = 4;

            Console.WriteLine($" A Horse name is: {horse1.Name}\n The Horse Age is: {horse1.Age}\n The Horse is: " +
                $"{horse1.Color}\n The Horse has {horse1.NumberOfEars} Ears and {horse1.NumberOfLegs} legs.");
            horse1.AnimalMove();
            horse1.AnimalSound();
            Console.ReadLine();
        }
    }
}
