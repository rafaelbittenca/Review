using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Mammal : Animal
    {
        public int Age { get; set; }
        public string Father { get; set; }
        public string Mother { get; set; }
        public decimal Weight { get; set; }
    }
}
