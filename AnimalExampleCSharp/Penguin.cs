using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public class Penguin : Bird
    {
        public Penguin(int Age, string Name) : base(Age, Name)
        {

        }
        public Penguin(int Age): this(Age, "Penquin")
        {


        }
        public Penguin()
        {

        }
        public override void eat(string food)
        {
        }
    }
}
