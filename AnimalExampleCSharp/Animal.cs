using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalExampleCSharp
{
    public abstract class Animal
    {

        //////////////////////////////////////Attributes//////////////////////////////
        private int age;
        private string name;

        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }


        /////////////////////////////////////Constructors////////////////////////////
        public Animal()
        {
            age = 1;
            name = "Bob";
        }
        ///////////////////////////////////Methods//////////////////////////////////
        public abstract void eat(string food);

        public void sleep(int lengthOfSkeeo)
        {
            //Sleep Method
        }

        public abstract Animal reproduce(Animal[] Parent);

        public abstract void breathe();

        public String poo()
        {
            return "I have logged this";
        }

        public void die()
        {
            // add die 
        } 
        
    }
}
