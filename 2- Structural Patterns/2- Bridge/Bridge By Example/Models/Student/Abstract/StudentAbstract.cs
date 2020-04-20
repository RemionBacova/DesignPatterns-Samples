using Bridge_By_Example.Models.Messagges.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_By_Example.Models.Student.Abstract
{
    public abstract class StudentAbstract : Interfaces.IStudent
    {
        private String _Name = "";
        private String _Surname = "";
        private MessageType _preferedMSGType;
        public abstract string Type { get; set; }//virtual property to be overriden which contains disticnt behaviour

       

        

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

        public MessageType messageType
        {
            get
            {
                return _preferedMSGType;
            }
            set
            {
                Random a = new Random();
                if (a.Next(0, 100) % 2 == 0)
                {
                    _preferedMSGType = MessageType.Email;
                }
                else
                {
                    _preferedMSGType = MessageType.SMS;
                }

                // for each student we establish randomly weather his preference is on sms or email message
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
