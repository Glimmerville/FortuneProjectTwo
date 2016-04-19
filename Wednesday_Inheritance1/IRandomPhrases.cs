using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Inheritance1
{
    interface IRandomPhrases//an interface is a template 
        //you can mix and match whether a thing is virtual in an abstract class
        //not so in an Interface.
        //"interface members cannot have a definition(body)"
    //ANY CLASS THAT USES THIS INTERFACE WILL BE REQUIRED TO
    //HAVE A PROPERTY CALLED RND (TYPE RANDOM)
    //A STRING LIST CALLED PHRASES
    //A METHOD CALLED CREATEpHRASES WITH ZERO PARAMS THAT RETURNS A VOID
    //AND ANOTHER METHOD CALLED GETPHRASE THAT HAS NO PARAMS AND RETURNS A STRING
    {
        Random rnd { get; set; } //declare a property w/o initializing it
        List<string>  Phrases { get; set; }
        void CreatePhrases(); //a method with no body or params, returns void
        string GetPhrase();//returns a string
    }
}
