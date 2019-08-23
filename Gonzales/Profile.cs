using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace martindes01.Gonzales
{
    class Profile
    {
        
        // Properties

        public string Name { get; set; }
        public int Speed { get; set; }
        public bool Acceleration { get; set; }


        // Constructors

        public Profile() { }

        public Profile(string name, int speed, bool acceleration)
        {
            Name = name;
            Speed = speed;
            Acceleration = acceleration;
        }


        // Methods

        public void Edit(string name, int speed, bool acceleration)
        {
            Name = name;
            Speed = speed;
            Acceleration = acceleration;
        }
    }
}
