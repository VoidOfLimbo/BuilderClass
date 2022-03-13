using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderClass
{
    class HouseBuilder : IBuilder
    {

        /* Concrete builder has methods for optional features */

        protected House currentHouse;

        public HouseBuilder()
        {
            currentHouse = new House();
        }

        public void Reset()
        {
            currentHouse = new House();
        }
        public void BuidWindows(int total)
        {
            currentHouse.Windows = total;
        }

        public void BuildDoors(int total)
        {
            currentHouse.Doors = total;
        }

        public void BuildRoofs(int total)
        {
            currentHouse.Roofs = total;

        }

        public void BuildWalls(int total)
        {
            currentHouse.Walls = total;
        }

        public void BuildPool()
        {
            currentHouse.SwimmingPool = true;
        }

        public void BuildStatue()
        {
            currentHouse.Statue = true;
        }

        public void BuildGarden()
        {
            currentHouse.Garden = true;
        }

        public void BuildGarage()
        {
            currentHouse.Garage = true;
        }

        public House GetHouse()
        {
            return this.currentHouse;
        }
    }
}
