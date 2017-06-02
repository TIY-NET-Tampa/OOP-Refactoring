using System;


namespace OOP_1
{
    public abstract class Thing
    {
        public Thing()
        {
            /*
             All classes should have a "DisplayName()" and a "DisplayGreeting()" method. 
             The "DisplayName()" function should return the value held in an instance variable "Name".

             */
        }
        private string Name { get; set; }
        public string DisplayName()
        {
            return this.Name;
        }
        public abstract string DisplayGreeting();
    }


}
