using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Inheritance1
{
    class FortuneTeller
    {
        //setting up stuff that may not be used yet
        //Properties
        public string Name { get; set; } = "Esmerelda"; //bonus content: should be able to make more than one teller.
        public string ExperienceLevel { get; set; }
        

        //Methods

        public void Greet()
        {
            Console.WriteLine("Hello! Welcome to my humble shop.");
            Console.WriteLine("Finest prices! Highest accuracy this side of Agrabah!");
            Console.WriteLine("\n");
            Console.WriteLine("Can I interest you in my services? (Y/N)");
            string yorn = Console.ReadLine();//it always continues anyway. We won't accept NO for an answer!
        }
        public void StartService(Service service)
        {
            Console.WriteLine("Ah yes of course! And what is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("I should have known! You look just like a {0}.\nBut I digress.", userName);
        }
        public void StartMerch(Merchandise service)
        {
            Console.WriteLine("Ah yes of course! And what is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("I should have known! You look just like a {0}.\nBut I digress.", userName);
            //    string Jewel = Console.ReadLine();
            //    Console.WriteLine("The {0} is indeed a beautiful gem. It surely resonates with your soul.", Jewel);
            //    Console.WriteLine("For you, I suggest my {0}! \nYes it will suit your needs, {2}. \nIt only costs {1}.", service.Name, service.Price, userName);
        }

        public void Farewell()
        {
            Console.WriteLine("Thank you for your patronage! Have a mystical day!");
        }
        /// <summary>
        /// Create a new fortune teller, giving it a name and experience level.
        /// </summary>
        /// <param name="name">The fortune teller's name.</param>
        /// <param name="experienceLevel">A string value (beginner, intermediate, advanced) for this fortune teller.</param>

        //Constructors
        public FortuneTeller(string name, string experienceLevel)
        {
            this.Name = name;
            this.ExperienceLevel = experienceLevel;//set up by Mel, not really implemented
        }

        public FortuneTeller()//default constructor
        {

        }

    }

}
