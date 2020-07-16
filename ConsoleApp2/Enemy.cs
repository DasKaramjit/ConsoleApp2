using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Enemy : GameObject
    {
        public Enemy(string name) 
            : base(name)
        {
        }

        //public method 
     
        public virtual void Firebullet()
        {
            Console.WriteLine("fire bullety");

        }

    }
}
