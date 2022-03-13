using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderClass
{
    class BuildManager
    {
        // object of parent interface can be initialised by implemented child class
        private IBuilder builder;

        public BuildManager(HouseBuilder newBuilder)
        {
            this.builder = newBuilder;
        }

        public void ChangeBuilder(HouseBuilder newBuilder)
        {
            this.builder = newBuilder;
        }

        public void buildHouse(BuildOptions.HouseType type)
        {
            this.builder.Reset();
            switch (type){
                case BuildOptions.HouseType.Simple:
                    buildSimple(4,1,4,16);
                    break;
                case BuildOptions.HouseType.WithPool:
                    buildSimple(6, 3, 8, 20);
                    addPool();
                    break;
                case BuildOptions.HouseType.WithGarden:
                    buildSimple(5, 4, 7, 18);
                    addGarden();
                    break;
                case BuildOptions.HouseType.withStatue:
                    buildSimple(6, 2, 6, 22);
                    addStatue();
                    break;
                case BuildOptions.HouseType.WithGarage:
                    buildSimple(4, 5, 8, 24);
                    addGarage();
                    break;
            }
        }
        private void buildSimple(int windows, int doors, int roofs, int walls)
        {
            builder.BuidWindows(windows);
            builder.BuildDoors(doors);
            builder.BuildRoofs(roofs);
            builder.BuildWalls(walls);
        }
        private void addPool()
        {
            (builder as HouseBuilder).BuildPool();
        }

        private void addStatue()
        {
            (builder as HouseBuilder).BuildStatue();
        }

        private void addGarden()
        {
            (builder as HouseBuilder).BuildGarden();
        }

        private void addGarage()
        {
            (builder as HouseBuilder).BuildGarage();
        }
    }
}
