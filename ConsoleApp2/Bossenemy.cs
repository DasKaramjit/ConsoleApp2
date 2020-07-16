using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Bossenemy : Enemy
    {
        //private instance 

            //public prop

            //constructor
        public Bossenemy(string name)
            : base("boss")
        {
        }


        //public method
        public override void Firebullet()
        {
            Console.WriteLine("big fire'");

        }
    }
}
