using Adapter_Sample_Objects.Models.Student.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Sample_Objects.Models.Student
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
