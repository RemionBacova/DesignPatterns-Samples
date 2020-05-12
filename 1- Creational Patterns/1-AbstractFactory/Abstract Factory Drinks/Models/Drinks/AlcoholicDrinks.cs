using Abstract_Factory_Drinks.Models.Drinks.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory_Drinks.Models.Drinks
{
    class AlcoholicDrinks : DrinksAbstract
    {
        public bool IsAlcoholic = true;
        public override bool SetComponent(string s)
        {
            if (this.Components.Contains(s))
            {
                return false;
            }
            else
            {
                // if s eshte alkolike ose jo
                this.Components.Add(s);
                return true;
            }
        }
    }
}
