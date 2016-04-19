using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Wednesday_Inheritance1
{
    class Magic:Service
    {
        //what kind of magic?
        public override decimal Price { get; set; }
        public override string Result { get; set; }
        public virtual bool BlackMagic { get; set; }
        public virtual int PercentEffective { get; set; }
        public override string Name { get; set; }
        //level of expertise you need to perform it
        internal enum DifficultyOptions { easy, medium, hard };
        //public virtual string Jewel { get; set; }

        //moved work to Service
        //what about a show-the-results method
        public virtual void Show()
        {
            Console.WriteLine("Oh, my. The mystical {0} told me, yes, it is your future!", this.Name);
            Console.WriteLine(this.Result);
        }

        public virtual void StateEffectiveness()
        {
            Console.WriteLine("In case you're wondering, this method is {2} percent accurate", this.Name, this.Result, this.PercentEffective);
        }
    }
}
