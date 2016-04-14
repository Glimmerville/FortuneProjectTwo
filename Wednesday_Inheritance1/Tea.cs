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
        //drink the tea - loose tea, so it can be um, read.
        //swirl it around in the cup 3x don't drink the gross part. Focus 
        //wait a sec or two (3 breaths)
        //look at the tea
        //invent meanings
        public override void Work()
        {
            base.Work();
            //now we will call a result method
            this.Result = "Test_test_test";
            Console.WriteLine(this.Result);
        }

        public Tea()
        {
            this.Price = 25.00M;
            this.PercentEffective = 25;
            this.BlackMagic = false;
            this.Expertise = "beginner";
            //I want to call my initializer for phrases
            //CreateTeaPhrases();
        }


    }
}
