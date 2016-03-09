using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class Penny
    {
        private readonly double _penny;

        public Penny()
        {
            _penny = .01;
        }

        public override string ToString()
        {
            return $"{_penny}";
        }
    }
}
