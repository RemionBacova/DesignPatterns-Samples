using FactoryMethod_Object_Example.Models.Student.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Object_Example.Models.Student
{
    class MasterStudent : StudentAbstract
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
                if (value == "Master")
                    this._Type = value;
                else
                {
                    //throw error 
                }
            }
        }
    }
}
