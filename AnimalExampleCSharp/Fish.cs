using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public abstract class Fish : Animal
    {
        public Fish()
        {

        }
        public Fish(int age, string name) : base(age, name)
        {

        }

        override public void breathe()
        {
            //Implement Breathe 
        }

        public override Fish reproduce(Animal[] otherParent)
        {
            return null;
        }

        public void Swim()
        {
            Console.WriteLine("I sure do love me some swimming");
        }
    }
}
