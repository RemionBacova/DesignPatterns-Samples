using Bridge_By_Example.Models.Messagges.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_By_Example.Interfaces
{
    public interface IStudent : IComparable
    {
        public MessageType messageType { get; set; }
        public String Type { get; set; } // type only get since it is established in the constructor of the object
        public String Name { get; set; }
        public String Surname { get; set; }
    }
}
