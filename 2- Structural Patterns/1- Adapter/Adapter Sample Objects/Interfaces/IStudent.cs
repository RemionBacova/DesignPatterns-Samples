using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Sample_Objects.Interfaces
{
    public interface IStudent : IComparable
    {
        public String Type { get; set; } // type only get since it is established in the constructor of the object
        public String Name { get; set; }
        public String Surname { get; set; }
    }
}
