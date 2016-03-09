using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class Quarter
    {
        private readonly double _quarter;

        public Quarter()
        {
            _quarter = .25;
        }
        public override string ToString()
        {
            return $"{_quarter}";
        }
    }
}
