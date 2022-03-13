using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderClass
{
    class House
    {
        /* House is our product and has all the attributes which will be set or unset by BuildManager as per the request of Architecture  */
        public int Windows { get; set; } = 0;
        public int Doors { get; set; } = 0;
        public int Walls { get; set; } = 0;
        public int Roofs { get; set; } = 0;

        public bool Garage { get; set; }
        public bool SwimmingPool { get; set; }
        public bool Statue { get; set; }
        public bool Garden { get; set; }

        public House() 
        {
            Garage = SwimmingPool = Statue = Garden = false;
        }

        public House(int window,
                     int door,
                     int wall,
                     int roof,
                     bool garage = false,
                     bool pool = false,
                     bool statue = false,
                     bool garden = false)
        {
            this.Windows = window;
            this.Doors = door;
            this.Walls = wall;
            this.Roofs = roof;
            this.Garage = garage;
            this.SwimmingPool = pool;
            this.Statue = statue;
            this.Garden = garden;
        }

        public override string ToString()
        {
            string output = "";
            output += "I have " + Windows + " windows\n";
            output += "I have " + Doors + " doors\n";
            output += "I have " + Walls + " walls\n";
            output += "I have " + Roofs + " roofs\n";
            if (Garage) output += "I have garage too\n";
            if (SwimmingPool) output += "I have swimming pool too\n";
            if (Statue) output += "I have fancy statues too\n";
            if (Garden) output += "I have gardens too\n";
            return output;
        }
    }
}
