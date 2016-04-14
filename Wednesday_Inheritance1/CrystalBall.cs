using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Inheritance1
{
    class CrystalBall:Magic
    {
        //plain field.
        private Random random = new Random();
        //HOW JACKIE DID THIS: made a list in properties, initialized called colorphrases
        //then made a method to get the color phrases
        //asked for favorite color in the method and returns one of the color phrases
        //that returns in the work method next to get phrase
    //properties
        protected List<string> Phrases { get; set; } = new List<string>();

        public override string Name { get; set; } = "Crystal Ball";

        public override void Work()
        {
            base.Work();
            //now we will call a result method
            this.Result = GetPhrase();
        }
        protected void CreatePhrases()
        {
            Phrases.Add("\"Night time is a dark place for you. Be careful of your choices.\"");
            Phrases.Add("\"Joy shines upon you with the coming of the dawn.\"");
            Phrases.Add("\"Stop and wait. Realign your energies. You are in conflict.\"");
            Phrases.Add("\"Now is the time to act! You must make your move immediately!\"");
            Phrases.Add("\"I see shiny objects in your near future.\"");
            Phrases.Add("\"The decorating around you is terrible Feng Shui.\"");
            Phrases.Add("\"Mars is in high sanction - don't start any business ventures.\"");
            Phrases.Add("\"If you always face the light, you will never see shadow.\"");
            Phrases.Add("\"The moon is full.. beware your tomorrows.");
            Phrases.Add("\"Never take your safety for granted. Death watches and paces restlessly.\"");
            Phrases.Add("\"The beautiful emerald resonates with your soul. Your aura will protect you.\"");
        }
        //overloaded method
        internal void CreatePhrases(string phrase)
        {
            Phrases.Add(phrase);
        }
        private string GetPhrase()
        {
            //local var
            int randomNumber = random.Next(Phrases.Count);
            return Phrases.ElementAt(randomNumber);
        }
        //constructor
        //let's override some of the properties of what we inehrited from magic & service
        public CrystalBall()
        {
            this.Price = 45.00M;
            this.PercentEffective = 65;
            this.BlackMagic = false;
            this.Expertise = "beginner";
            //I want to call my initializer for phrases
            CreatePhrases();
        }
    
        

        
    }
}
