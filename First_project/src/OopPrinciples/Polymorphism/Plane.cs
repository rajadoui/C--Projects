using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.OopPrinciples.Polymorphism
{
  public class Plane : Vehicule
  {
    public int NumberOfDoors { get; set; }

    public override void Start()
    {
      Console.WriteLine("Plane is starting.");
    }

    public override void Stop()
    {
      Console.WriteLine("Plane is stopping.");
    }

  }
}