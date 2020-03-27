using Builder_Object_Example.Interfaces;
using System;

namespace Builder_Object_Example.Builders.Student.Abstract
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
