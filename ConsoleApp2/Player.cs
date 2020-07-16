using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Player : GameObject
    {

        //private instance var


            //properties

            //constructor
        public Player() 
            : base("Player")
        {
        }
        //public method
        public void Raiseshield()
        {
            Console.WriteLine("Raise sgield");
        }

    }
}
