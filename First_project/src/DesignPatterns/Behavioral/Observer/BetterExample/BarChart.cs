using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_project.src.DesignPatterns.Behavioral.Observer.BetterExample
{
    public class BarChart : IObserver
    {

        private DataSource _dataSource;

        public BarChart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public void Update()
        {
            System.Console.WriteLine("Rendering bar chart with new values");
        }
    }

}