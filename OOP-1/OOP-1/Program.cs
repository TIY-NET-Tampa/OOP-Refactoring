using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var human = new Human();
            var robot = new Robot();
            var panda = new Panda();

            var everything = new List<Thing> { human, robot, panda };

            everything.ForEach(f =>
            {
                Console.WriteLine(f.DisplayName());
                Console.WriteLine(f.DisplayGreeting());
            });
            Console.WriteLine(robot.StartUp());
            Console.WriteLine(robot.ShowDown());
            Console.WriteLine(robot.IsTerminator);

            var creatues = new List<LivingThing> { human, panda };
            creatues.ForEach(c =>
           {
               c.GoToSleep();
               Console.WriteLine($"should be asleep {c.IsAsleep}");
               c.WakeUp();
               Console.WriteLine($"should be awake {c.IsAsleep}");

           });
            Console.WriteLine($"Robot should be shut down {robot.IsAsleep}");


            var house = new ThingContainer<Thing>();

            var zoo = new ThingContainer<LivingThing>();

            house.Container.Add(robot);
            house.Container.Add(panda);

            zoo.Container.Add(human);
       



            Console.ReadLine();
        }
    }
}
