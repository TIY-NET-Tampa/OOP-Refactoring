using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
   public class ThingContainer<T>
    {
        public List<T> Container { get; set; } = new List<T>();

        public void AddToContainer(T item)
        {
            this.Container.Add(item);
        }
    }
}
