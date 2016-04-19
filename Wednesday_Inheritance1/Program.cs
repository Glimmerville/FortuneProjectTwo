using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Inheritance1
{
    class Program
    {
        public static List<Service> AvailableServices { get; set; } = new List<Service>();
        //static means 'you can use it without instantiating an object' they are added when they are instantiated
        static void Main(string[] args)
        {
            //our game will start here
            //let's create some SERVICES
            FortuneTeller fortuneTeller = new FortuneTeller();//these are objects
            CrystalBall crystalBall = new CrystalBall();//child of magical, child of services
            Tea tea = new Tea(); //we are going to have an option to read tea leaves instead.
            Palmistry palmistry = new Palmistry();

            Kites kites = new Kites(); //We need a "non-magic option" so here we shall sell kites.
            FortuneTeller.Greet(); //say hi
            do
            {
                fortuneTeller.ListServices();
                int selection = int.Parse(Console.ReadLine());
                //get service at the index of the num -1
                Magic selectedService = (Magic)AvailableServices[0];//casting into a parent, instantiating 'new object of type magic called selectedservice'
                try//setting up 0 as default selection
                {
                    selectedService = (Magic)AvailableServices[selection - 1];//to get number on list, from index (0) but we will ask them 1
                }
                catch (Exception e)
                {
                    //console.WriteLine(e.Message);
                    Console.WriteLine("I didn't catch that so I will do {0}", selectedService);
                }
                fortuneTeller.StartService(selectedService);
                selectedService.Work();//now this one list will run whatever the slection was instead of crystalball.Work(), tea.Work(), etc.
                selectedService.Show();
                selectedService.StateEffectiveness();
                fortuneTeller.PlayAgain();//Ok I guess I need to add PlayAgain();
            } while (Console.ReadLine() == "Y");
            fortuneTeller.Farewell();
        }
    }
}

            //Console.WriteLine("Are you interested in my (C)rystal ball, \nor having your (T)ea leaves read? \nPerhaps (P)alm reading is more your style?\nOr would you like to buy a (K)ite? Please answer C, T or K.");
            //string pickService = Console.ReadLine().ToUpper();
            //if (pickService == "C")
            //{
            //    fortuneTeller.StartService((Service)crystalBall);//this is where we instantiate the object crystalball
            //    crystalBall.Work();
            //    crystalBall.Show();
            //    crystalBall.StateEffectiveness();
            //}
            //else if (pickService == "T")
            //{
            //    fortuneTeller.StartService((Service)tea);//this is where I told it to make (instantiate obj) tea
            //    tea.TeaReading();
            //    tea.Work();
            //    tea.Show();
            //}
            //else if (pickService == "P")
            //{
            //    fortuneTeller.StartService((Service)palmistry);
            //    palmistry.PalmReading();
            //    palmistry.Work();
            //    palmistry.Show();
            //}
            //else
            //{
            //    fortuneTeller.StartMerch((Merchandise)kites);
            //    kites.Sale();
            //    Kites PurchasedKite = new Kites(4, 36, "delta", true, "green");
            //}
            //Console.WriteLine("I did not really finish implementing selling kites yet.");
            //Console.ReadKey();//I put this here for the sake of making the experience nicer.

            // fortuneTeller.StartService((Service)pickService);
            //Per MEL: Why did we cast this here to its grandfather type (service) think it over?
            //fortuneTeller.Farewell();
        
        //NOTES FROM CLASS WITH MEL:
        //make it expandable in the future she may want more services
        //that is why we made a thing to hold all the services (for MONEY this is a business)
        //so CrystalBall is not a service, what it does is the service We can add more this way!
        //this is the same idea as how you break up data in SQL / db design
        //since crystal ball is a magic is a service, you can convert it via casting!
        //could you add custom info to incorporate into the answers based on asking the user stuff?
    
    

