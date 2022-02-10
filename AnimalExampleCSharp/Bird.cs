﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public abstract class Bird:Animal
    {
        public Bird():this(1, "Bird")
        {

        }
        public Bird(int age, string name) : base(age, name)
        {

        }

        override public void breathe()
        {
            //Implement Breathe 
        }

        public override Bird reproduce(Animal[] otherParent)
        {
            return null;
        }
    }
}
