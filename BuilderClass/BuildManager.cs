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
                    buildSimple();
                    break;
                case BuildOptions.HouseType.WithPool:
                    buildSimple();
                    addPool();
                    break;
                case BuildOptions.HouseType.WithGarden:
                    buildSimple();
                    addGarden();
                    break;
                case BuildOptions.HouseType.withStatue:
                    buildSimple();
                    addStatue();
                    break;
                case BuildOptions.HouseType.WithGarage:
                    buildSimple();
                    addGarage();
                    break;
            }
        }
        private void buildSimple()
        {
            builder.BuidWindows(4);
            builder.BuildDoors(2);
            builder.BuildRoofs(4);
            builder.BuildWalls(16);
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
