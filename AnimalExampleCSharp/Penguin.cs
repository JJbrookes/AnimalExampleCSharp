using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public class Penguin : Bird
    {
        string food;

        public string Food { get => food; set => food = value; }

        public override void eat(string food)
        {

        }
    }
}
