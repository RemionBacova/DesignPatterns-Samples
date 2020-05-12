using Abstract_Factory_Drinks.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Drinks.Models.Drinks.Abstract
{
    abstract class DrinksAbstract : IDrinks
    {

        public String Name;
        public List<String> Components = new List<string>();
        public List<string> GetComponenets()
        {
            return Components;
        }

        public abstract bool SetComponent(string s);
        
    }
}
