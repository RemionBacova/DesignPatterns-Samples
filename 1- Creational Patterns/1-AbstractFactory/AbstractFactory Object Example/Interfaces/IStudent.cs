using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_Object_Example.Interfaces
{
    interface IStudent
    {
        public String Type { get; set; } // type only get since it is established in the constructor of the object
        public String Name { get; set; } 
        public String Surname { get; set; }

        
    }
}
