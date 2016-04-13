using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Inheritance1
{
    class Service
    {
        //WHY might we want to make this an "ABSTRACT" instead of virtual?
        //Abstracts are virtuals that you can't put a default into 

        //properties
        //services have costs and we want to be able to change/override
        public virtual decimal Price { get; set; }

        //all services have a name.
        public virtual string Name { get; set; }

        //Let's make a property to store some result. Let's just say it's a single result and it's a string.
        public virtual string Result { get; set; }

        //We might want to track other things too, but we can add on later if we'd like

    }
}
