using System;

namespace BuilderClass
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  .NET 5.0 has simplified instantiation use this format for other frameworks
             *  if needed HouseBuilder simpleHouse = new HouseBuilder();
             *  We can also make seperate builders as seperate class such as SimpleHouseBuilder, HouseWithGarden etc... 
             *  Then the syntax would be 
             *  HouseBuilder simpleHouse = new SimpleHouseBuilder()
             *  HouseBuilder simpleHouse = new HouseWithGarden()
             *  .....
             */
            HouseBuilder simpleHouse = new();
            HouseBuilder houseWithGarden = new();
            HouseBuilder houseWithGarage = new();
            HouseBuilder houseWithStatues = new();
            HouseBuilder houseWithPool = new();

            BuildManager director = new(simpleHouse);
            
            // build simple house
            director.buildHouse(BuildOptions.HouseType.Simple);

            // now build house with garden
            director.ChangeBuilder(houseWithGarden);
            director.buildHouse(BuildOptions.HouseType.WithGarden);

            // now build house with garage
            director.ChangeBuilder(houseWithGarage);
            director.buildHouse(BuildOptions.HouseType.WithGarage);

            // now build house with statues
            director.ChangeBuilder(houseWithStatues);
            director.buildHouse(BuildOptions.HouseType.withStatue);
            
            // now build house with pool
            director.ChangeBuilder(houseWithPool);
            director.buildHouse(BuildOptions.HouseType.WithPool);


            Console.WriteLine("\nConcrete Implementation 1\n" + simpleHouse.GetHouse());
            Console.WriteLine("\nConcrete Implementation 2\n" + houseWithGarden.GetHouse());
            Console.WriteLine("\nConcrete Implementation 3\n" + houseWithGarage.GetHouse());
            Console.WriteLine("\nConcrete Implementation 4\n" + houseWithStatues.GetHouse());
            Console.WriteLine("\nConcrete Implementation 5\n" + houseWithPool.GetHouse());

            Console.ReadKey();

        }
    }
}
