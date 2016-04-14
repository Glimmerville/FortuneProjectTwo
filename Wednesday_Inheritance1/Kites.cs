using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Inheritance1
{
    class Kites : Service
    {
        //here let's make a field.
        private Random random = new Random();
        //what kind of kites?
        public string Shape { get; set; } //delta, diamond
        public virtual bool Stunt { get; set; } //is it a stunt kite?
        public virtual int Lines { get; set; }//number of kite lines
        public override string Name { get; set; }
        //level of expertise you need to perform it
        protected virtual string Expertise { get; set; } //how hard is the kite to fly
        //public virtual string Jewel { get; set; }

        public virtual void Sale()
        {
            Console.WriteLine("Here are the available kites for sale:");
            //list of kites will go here - make a switch case I think.
            
        }
    }
}
