using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            //our game will start here
            //let's create a fortune teller
            FortuneTeller fortuneTeller = new FortuneTeller();//these are objects
            CrystalBall crystalBall = new CrystalBall();//child of magical, child of services
            Tea tea = new Tea(); //we are going to have an option to read tea leaves instead.
            Kites kites = new Kites(); //We need a "non-magic option" so here we shall sell kites.
            fortuneTeller.Greet(); //say hi
            Console.WriteLine("Are you interested in my (C)rystal ball, \nor having your (T)ea leaves read? Or would you like to buy a (K)ite? Please answer C, T or K.");
            string pickService = Console.ReadLine();
            if (pickService == "C" || pickService == "c")
            {
                fortuneTeller.StartService((Service)crystalBall);
                crystalBall.Work();
                crystalBall.Show();
                crystalBall.StateEffectiveness();
            }
            else if (pickService == "T" || pickService == "t")
            { 
                fortuneTeller.StartService((Service)tea);
                tea.Work();
            }
            else 
            {
                fortuneTeller.StartService((Service)kites);
                kites.Sale();
                Console.WriteLine("I did not really finish implementing selling kites yet.");
                Console.ReadKey();//I put this here for the sake of making the experience nicer.
            }
           // fortuneTeller.StartService((Service)pickService);
            //Per MEL: Why did we cast this here to its grandfather type (service) think it over?
            fortuneTeller.Farewell();
            //NOTES FROM CLASS WITH MEL:
            //make it expandable in the future she may want more services
            //that is why we made a thing to hold all the services (for MONEY this is a business)
            //so CrystalBall is not a service, what it does is the service We can add more this way!
            //this is the same idea as how you break up data in SQL / db design
            //since crystal ball is a magic is a service, you can convert it via casting!
            //could you add custom info to incorporate into the answers based on asking the user stuff?
    }
    }
}
