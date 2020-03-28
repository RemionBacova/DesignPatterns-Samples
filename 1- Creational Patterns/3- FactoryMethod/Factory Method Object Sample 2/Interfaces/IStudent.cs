using System;

namespace Factory_Method_Object_Sample_2.Interfaces
{
    public interface IStudent
    {
        public String Type { get; set; } // type only get since it is established in the constructor of the object
        public String Name { get; set; }
        public String Surname { get; set; }

    }
}
