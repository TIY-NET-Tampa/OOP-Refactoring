using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    class Program
    {

        //final goal is to have a location heiracrhy
        
            // each location has a name, latitude and longitude
       public class Location
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public float Latitude { get; set; }
            public float Longitude { get; set; }

            public override string ToString()
            {
                return $"This location is {this.Name} at {this.Address}, at {this.Latitude},{this.Longitude}";
            }
        }



        static void Main(string[] args)
        {
            var loc1 = new Location();
            loc1.Address = "123 here";
            loc1.Name = "TIY";
            loc1.Longitude = 25F;
            loc1.Latitude = 82F;

            Console.WriteLine(loc1);

            Console.ReadLine();
        }
    }
}
