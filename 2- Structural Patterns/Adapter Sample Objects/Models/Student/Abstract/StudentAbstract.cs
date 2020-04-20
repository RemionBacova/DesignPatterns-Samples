using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Sample_Objects.Models.Student.Abstract
{
    public abstract class StudentAbstract : Interfaces.IStudent
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

        public int CompareTo(object student)
        {
            if (student is StudentAbstract)
            {
                return this._Name.CompareTo(((StudentAbstract)student)._Name) + this._Surname.CompareTo(((StudentAbstract)student)._Surname);
            }
            else
            {
                return -10000;
            }
        }

        #endregion

    }
}
