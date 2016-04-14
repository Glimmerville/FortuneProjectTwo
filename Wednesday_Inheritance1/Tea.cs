using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Inheritance1
{
    class Tea:Magic
    {
        //here let's make a field.
        private Random random = new Random();
        //Tasseography
        public override string Name { get; set; } = "Tea";

        public void TeaReading()
        {
            Console.WriteLine("Let me pour you a cup of fine, green tea.");
        }
        //Print message about: drink the tea - comment about the leaves
        //print message about: swirl it around in the cup 
        //Print message about: looking at the tea
        //invent meanings - pull from list of phrases.
        public override void Work()
        {
            base.Work();
            //now we will call a result method
            this.Result = GetTPhrase();
            Console.WriteLine(this.Result);
        }

        public Tea() //this is not used anywhere right now
        {
            this.Price = 25.00M;
            this.PercentEffective = 25;
            this.BlackMagic = false;
            this.Expertise = "beginner";
        }
            //I want to call my initializer for phrases

        protected List<string> TeaPhrases { get; set; } = new List<string>();

        protected void CreateTeaPhrases()
        {
            TeaPhrases.Add("\"The leaves form a bat. Are you into superheroes?\"");
            TeaPhrases.Add("\"The leaves kind of look like a round globby mess.\"");
            TeaPhrases.Add("\" Very interesting. The sign of the sun means you will go on vacation!\"");
            TeaPhrases.Add("\"Is that a tree? It looks like uh, you will have Christmas?\"");
            //add more phrases
        }
        private string GetTPhrase()
        {
            //local var
            int randomNumber = random.Next(TeaPhrases.Count);
            return TeaPhrases.ElementAt(randomNumber);
        }
    }//I used the same pattern Mel did with Crystal Ball but it always breaks here


}

