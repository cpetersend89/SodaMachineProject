using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class Nickel
    {
        private readonly double _nickel;

        public Nickel()
        {
            _nickel = .05;
        }
        public override string ToString()
        {
            return $"{_nickel}";
        }
    }
}
