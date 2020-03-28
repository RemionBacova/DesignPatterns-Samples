using Factory_Method_Object_Sample_2.Interfaces;
using System;

namespace Factory_Method_Object_Sample_2.Builders.Student.Abstract
{
    abstract class StudentBuilderAbstract : IStudentBuilder
    {
        internal Interfaces.IStudent _Student;
        public abstract void BuildObjct();
        public void SetProperties(int i)
        {
            if (_Student is null)
            {
                throw new NotImplementedException();
            }
            else
            {
                _Student.Name = "St" + i.ToString() + "Name";
                _Student.Surname = "St" + i.ToString() + "Surname";
            }
        }
        public Interfaces.IStudent GetStudent()
        {
            return _Student;
        }

       
       
    }
}
