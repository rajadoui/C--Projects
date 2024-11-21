using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ConsoleApp1.src.OopPrinciples.Inheritance
{

    public class Vehicule
    {
        public string Brand {get; set; }

        public string Model {get; set; }

        public int Year {get; set; }

        public void Start()
        {
            Console.WriteLine("Vehicule is starting");
        }

        public void Stop()
        {
            Console.WriteLine("Vehicule is stopping");
        }

    }

}