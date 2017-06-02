using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        public class MyContainer<T>
        {
            public List<T> Container { get; set; } = new List<T>;
        }

        static void Main(string[] args)
        {
        }
    }
}
