using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public abstract class Mammal: Animal
    {
        //////////////Attributes/////////////////
        

        //////////////Constuctors///////////
        public Mammal(int age=0, string name="") : base(age, name)
        {

        }
        //////////////Methods////////////////


        override public void breathe() 
        {
            //Implement Breathe 
        }

        public override Mammal reproduce(Animal[] otherParent)
        {
            return null;
        }
    }
}
