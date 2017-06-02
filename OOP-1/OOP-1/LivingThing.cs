using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
   public abstract class LivingThing : Thing, ISleeping
    {
 
        public LivingThing(string name):base(name)
        {

        }
        public string Eat(string food)
        {
            return $"Yum, I eat {food}";
        }
        public bool GoToSleep()
        {
            this.IsAsleep = true;
            return this.IsAsleep;
        }
        public bool WakeUp()
        {
            this.IsAsleep = false;
            return this.IsAsleep;
        }
    }
}
