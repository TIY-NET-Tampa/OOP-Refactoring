using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Robot : Thing
    {
        public bool IsTerminator { get; set; } = false;

        public Robot() : base("Robot")
        {

        }
        public override string DisplayGreeting()
        {
            return "beep boop I am a robot";
        }
        public string StartUp()
        {
            this.IsAsleep = false;
            return "Starting up";
        }
        public string ShowDown()
        {
            this.IsAsleep = true;
            return "Shutting down";
        }

    }
}
