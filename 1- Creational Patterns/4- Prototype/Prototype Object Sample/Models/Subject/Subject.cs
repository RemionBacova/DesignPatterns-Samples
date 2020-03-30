using Prototype_Object_Sample.Models.Subject.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype_Object_Sample.Models.Subject
{
    public class Subject : SubjectPrototype
    {
        #region IClonable Interface Implementation
        public override object Clone()
        {
            return this.MemberwiseClone() as Subject;
        }
        public override object DeepClone()
        {
            Subject cpy = this.MemberwiseClone() as Subject;
            cpy.MainTeacher = new Teacher.Teacher
            {
                Name = this.MainTeacher.Name,
                Surname = this.MainTeacher.Surname,
                Title = this.MainTeacher.Title
            };

            cpy.Substitues = new List<Teacher.Teacher> (this.Substitues); // copies list 

            return cpy;
        }

        public override object DeepClone2()
        {
            Subject cpy = this.MemberwiseClone() as Subject;
            cpy.MainTeacher = new Teacher.Teacher
            {
                Name = this.MainTeacher.Name,
                Surname = this.MainTeacher.Surname,
                Title = this.MainTeacher.Title
            };

            cpy.Substitues =  this.Substitues.Select(item => (Teacher.Teacher)item.Clone()).ToList(); // clones list

            return cpy;
        }
        #endregion

        #region IComparable Interface Implementation
        public override int CompareTo(object obj)
        {
            throw new NotImplementedException(); // to be done
        }

        public override int DeepCompareTo(object obj)
        {
            throw new NotImplementedException(); // to be done
        }


        #endregion
    }
}
