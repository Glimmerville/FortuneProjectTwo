using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wednesday_Inheritance1
{
    internal enum DifficultyOptions { easy, medium, hard }; //note these aren't in quotes. Kind of like a constant. Choose not alter.

    //BUT you WANT every service to have a price/name & result! so we add Abstract
    //put abstract here at class level does not mean all the ones under it has to be abstract as well
    //but you must have class abstract to have the option to make the stuff under it abstract
    class Service:Commerce
    {
        //properties
        //services have costs and we want to be able to change/override
        //these are "Virtual" because you never call "service" on its own
        //you can have virtual methods in an abstract class. 
        //We MUST use price in every child if it is abstract
        //public abstract decimal Price { get; set; }

        //all services have a name.
        public override string Name { get; set; }
        public override decimal Price { get; set; }
        public virtual string Result { get; set; }

        public virtual void Work()
        {
            Console.WriteLine("Let me pull out my {0}.", this.Name);
            Thread.Sleep(2000);
            //Console.WriteLine("\n\nI gaze.\n\nI gaze...\n");
            //Thread.Sleep(4000);
        }
        public virtual Enum Difficulty { get; set; } = DifficultyOptions.medium;
    }
}
