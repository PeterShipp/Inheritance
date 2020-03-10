using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    abstract class Animals
    {
        protected string name;
        protected int numOfLegs;
        protected int numOfArms;
        protected bool isDangerous;
        protected bool isFurry;

        public void Sleep() {
            Console.WriteLine("The " + this.GetType() + " goes to sleep.");
        }

        public void Eat()
        {
            Console.WriteLine("The" + this.GetType() + " goes to eats.");
        }

        public virtual void Breath()
        {
            Console.WriteLine("The animal breathes through it's nose!");
        }

        public abstract int Sell();
    }
}
