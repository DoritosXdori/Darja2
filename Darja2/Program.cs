using System;

namespace Darja2
{
    class Program
    {
        class Cat
        {
            string name;
            string color ;
            double hungers;
            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hungers = 0;
                Console.WriteLine($"The cat {name} has been created.");
            }
            public double Hungers
            {
                get { return hungers; }
            }
            public void Sleep()
            {
                Console.WriteLine(" sleep ");
                hungers += 0.2;

            }

            public void Wiggle()
            {
                Console.WriteLine("Mau-mau");
            }
            public void Rename(string newName)
            {
                name = newName;
            }
            public void ShowCatData()
            {
                Console.WriteLine($"Name: {name}; Color: {color}; Hungers: {hungers};");
            }

          
        }
        static void Main(string[] args)
        {

            Cat newCat = new Cat("London", "Red");
            Console.WriteLine($"The level of Hungers: {newCat.Hungers}");
            while (newCat.Hungers != 1) 
            {
                newCat.Sleep();
            }
            newCat.Wiggle();

            Console.WriteLine("Name the cat: ");
            string newCatName = Console.ReadLine();
            newCat.Rename(newCatName);
            newCat.ShowCatData();
        }
        
    }
}
