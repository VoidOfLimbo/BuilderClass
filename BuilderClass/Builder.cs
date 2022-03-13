using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderClass
{
    interface IBuilder
    {
        /* Only necessary methods in builder interface */
        void Reset();
        void BuidWindows(int total);
        void BuildDoors(int total);
        void BuildWalls(int total);
        void BuildRoofs(int total);
    }
}
