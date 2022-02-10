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
        public int Age { get;  set; }
        public string Name { get;  set; }
        public double Weight { get; set; }
        public string Sex { get; set; }
        public string Colour { get; set; }
        /////////////////////////////////////Constructors////////////////////////////
        public Animal()
        {
            Name = "Animal";
            Age = 1;
            Weight = 10;
            Sex = string.Empty;
            Colour = string.Empty;
        }
        public Animal(int age, string name):this()
        {
            this.Age = age;
            this.Name = name;
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

        public void die(int averageLifespan)
        {
            if(Age > averageLifespan)
            {

            }
            else if (Age > averageLifespan)
            {

            }
        } 
        
    }
}
