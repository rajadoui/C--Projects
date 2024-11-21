using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ConsoleApp1.src.OopPrinciples.Polymorphism
{

    public class Vehicule
    {
        public string Brand {get; set; }

        public string Model {get; set; }

        public int Year {get; set; }

        public virtual void Start() // Virtual methods are methods in a base class that you allow to be overriden in any derived (inherited) class. It allow child classes to provide
        // their own implementation for this method. Virtual methods are part of C#'s polymorphism feature
        {
            Console.WriteLine("Vehicule is starting");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Vehicule is stopping");
        }

    }

}