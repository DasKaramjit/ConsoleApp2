using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Transform
    {
        // public instance variable
        public Vector2D position;
        public Vector2D rotation;
        public Vector2D scale;

        //constructor
        public Transform()
        {
            m_initialise();
        }

        //public method
        private void m_initialise()
        {
            position = new Vector2D();

            rotation = new Vector2D();
            scale = new Vector2D();
        }
        public override string ToString()
        {
            string outputstring = "";
            outputstring += $"position"+position.ToString()+"\n";
            outputstring += $"rotation" + rotation.ToString()+"\n";
            outputstring += $"scale" + scale.ToString();
            return outputstring;
        }
    }
}
