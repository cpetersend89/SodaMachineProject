using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class Dime
    {
        private readonly double _dime;

        public Dime()
        {
            _dime = .01;
        }
        public override string ToString()
        {
            return $"{_dime}";
        }
    }
}
