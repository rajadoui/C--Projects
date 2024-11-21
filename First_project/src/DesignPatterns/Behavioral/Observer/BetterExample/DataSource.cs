using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_project.src.DesignPatterns.Behavioral.Observer.BetterExemple;

namespace First_project.src.DesignPatterns.Behavioral.Observer.BetterExample
{
    public class DataSource : Subject
    {

        private List<int> _values = new List<int>();

        public List<int> GetValues()
        {
            return _values;
        }

        public void SetValues(List<int> values)
        {
            _values = values;

            NotifyObservers();
        }
    }
}