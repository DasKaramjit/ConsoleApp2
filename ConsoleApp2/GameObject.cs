using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class GameObject
    {
        // instance properties
        private string m_name;
        public Transform Transform { get; set; }
        public string Name
        {
            get
            {
                return this.m_name;

            }
            set
            {
                this.m_name = value;
            }
        }
        //const

        public GameObject(string name)
        {
           Name = name;
            m_initialise();
        }
        //private method
        public void m_initialise()
        {
            Transform = new Transform();
        }

        public override string ToString()
        {
            string outputstring="";
            outputstring += $"Name   : {Name}";
            outputstring += Transform.ToString();

            return outputstring;
        }
    }
}
