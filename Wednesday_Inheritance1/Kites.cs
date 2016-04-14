using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Inheritance1
{
    class Kites:Merchandise
    {
        //here let's make a field.
        private Random random = new Random();//maybe for kite color
        //what kind of kites?
        public string Shape { get; set; } //delta, diamond, sled, etc.
        public bool Stunt { get; set; } //is it a stunt kite?
        public int Lines { get; set; }//number of kite lines
        public int Size { get; set; } //size of the kite
        public string Color { get; set; } //kite color
        public string kiteInterest { get; set; } //kite they are interested in buying
        public override string Name { get; set; }//if kite has a name. Not sure I will use
        //level of expertise you need to perform it
        protected virtual string Expertise { get; set; } //how hard is the kite to fly
        

        public void KitesList(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Dragon");
                    kiteInterest = "dragon";
                    break;
                case 2:
                    Console.WriteLine("Parafoil");//stunt or not stunt (bool)
                    kiteInterest = "Parafoil";
                    break;
                case 3:
                    Console.WriteLine("Delta");//stunt or not stunt (bool)
                    kiteInterest = "Delta";
                    break;
                case 4:
                    Console.WriteLine("Sled");
                    kiteInterest = "Sled";
                    break;
                case 5:
                    Console.WriteLine("Fighter");
                    kiteInterest = "Fighter";
                    break;
                case 6:
                    Console.WriteLine("Diamond");//stunt or not stunt (bool)
                    kiteInterest = "Diamond";
                    break;
                default:
                    Console.WriteLine("Quit");
                    break;
            }
        }
      //kite constructors - neither of these constructors work but I am not sure why
      public void Kite()
        {
            //default kite
        }
      public void Kite(int kLines, int kSize, string kShape, bool kStunt, string kColor )
        {
            this.Lines = kLines;
            this.Stunt = kStunt;
            this.Size = kSize;
            this.Shape = kShape;
            this.Color = kColor;
        }
        
        public virtual void Sale()
        {
            Console.WriteLine("\nHere are the types of Kites I have for sale:\n");
            //list of initial kite options
            Console.WriteLine("1.  Dragon");//these are saved as string "kiteInterest"
            Console.WriteLine("2.  Parafoil");
            Console.WriteLine("3.  Delta");
            Console.WriteLine("4.  Sled");
            Console.WriteLine("5.  Fighter");
            Console.WriteLine("6.  Diamond");
            Console.WriteLine("7.  Quit Buying a Kite");
            //TO DO:
            //get all the values (stunt or not stunt, how many strings, color, etc.) 
            //and then construct a new instance of Kite using them
            //but my constructor is not working.

            //print the object they made (via selections) to the screen
            //ask if that is what they want to buy
            //print a cost. Would be cool to make the cost made up of their selections
            //but that would take more time than I have.

        }
      // Kite PurchasedKite = new Kite()   <<<< WHY DOES MY CONSTRUCTOR NOT WORK?
        }
    }

