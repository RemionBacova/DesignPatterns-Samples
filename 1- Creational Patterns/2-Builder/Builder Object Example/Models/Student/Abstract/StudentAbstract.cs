
using System;

namespace Builder_Object_Example.Models.Student.Abstract
{
    abstract class StudentAbstract : Interfaces.IStudent
    {
        private String _Name = "";
        private String _Surname = "";
        public virtual string Type { get; set; }//virtual property to be overriden which contains disticnt behaviour

        //Common behaviour for the distinct models

        #region Common Behaviour 
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
            }
        }
        public string Surname
        {
            get
            {
                return this._Surname;
            }
            set
            {
                this._Surname = value;
            }
        }
        #endregion

    }
}
