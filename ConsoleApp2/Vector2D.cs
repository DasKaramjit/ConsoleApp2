using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   class Vector2D
    {
        //instance variable
        public float x;
        public float y;

        //cons tructor
        public Vector2D(float x = 0.0f, float y=0.0f)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            string outputstring=$"({x} ,{y})";
            return outputstring;
            
        }

    }
   
}
