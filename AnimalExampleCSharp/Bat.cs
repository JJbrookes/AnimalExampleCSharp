using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public  class Bat: Mammal, Flying
    {

        public Bat()
        {

        }
        public Bat(int age, string name) : base(age, name)
        {

        }
        public override void eat(string food)
        {

        }

        public void landing()
        {

        }

        public void takeOff()
        {

        }

        public void flight()
        {
            Console.WriteLine("WoW look at me im doin the flying!");
        }

    }
}
