using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_project.src.DesignPatterns.Behavioral.Observer.BetterExample
{
    public class Sheet2 : IObserver
    {
        private int _total;

        private DataSource _dataSource;

        public Sheet2(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public int GetTotal()
        {
            return _total;
        }

        public void Update()
        {
            _total = CalculateTotal(_dataSource.GetValues());
        }        

        public int CalculateTotal(List<int> values)
        {
            var sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }
            System.Console.WriteLine("Total: " + sum);
            return sum;
        }
    }

    public interface IObserver
    {
    }
}