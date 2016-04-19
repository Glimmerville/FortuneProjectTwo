using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Inheritance1
{
    abstract class Merchandise:Commerce
    {
        //Not sure what to put here that is specific to merchandise but not service
        //but I still feel we need this here because it is different.
        //properties
        //services have costs and we want to be able to change/override
        public override decimal Price { get; set; }
        public override string Name { get; set; }
        //availability
        //inventory

    }
}
