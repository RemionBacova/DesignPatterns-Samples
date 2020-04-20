using Bridge_By_Example.Models.Messagges.Types;
using Bridge_By_Example.Models.Student.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_By_Example.Models.Student
{
    class BachelorStudent : StudentAbstract
    {
        private string _Type = "";

        public override string Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                if (value == "Bachelor")
                    this._Type = value;
                else
                {
                    //throw error 
                }
            }
        }

      

    
        // should imiplement message Type by
    }
}
