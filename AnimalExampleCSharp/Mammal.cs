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
