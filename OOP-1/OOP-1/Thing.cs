using System;


namespace OOP_1
{

    /*
             All classes should have a "DisplayName()" and a "DisplayGreeting()" method. 
             The "DisplayName()" function should return the value held in an instance variable "Name".

             */
    public abstract class Thing
    {
        private string Name { get; set; } = "A class has no name";
        public bool IsAsleep { get; set; } = false;
        public Thing()
        {

        }
        public Thing(string name)
        {
            this.Name = name;
        }

        public string DisplayName()
        {
            return this.Name;
        }
        public abstract string DisplayGreeting();
    }


}
