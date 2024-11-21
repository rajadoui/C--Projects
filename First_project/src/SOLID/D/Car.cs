using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_project.src.SOLID.D
{
    public class Car
    {
        private IEngine engine;

        public Car(IEngine engine)
        {
            this.engine = engine; 
        }

        public void StartCar() 
        {
            engine.Start();
            System.Console.WriteLine("Car started.");
        }

    }
}