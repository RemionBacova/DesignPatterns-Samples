using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Drinks.Interfaces
{
    interface IDrinks
    {
        public List<String> GetComponenets();
        public bool SetComponent(string s);
    }
}
