using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_Object_Sample.Models.Subject.Prototype
{
    public abstract class SubjectPrototype : ICloneable, IComparable
    {
        public string Nomination { get; set; }
        public int Year { get; set; }

        public Teacher.Teacher MainTeacher { get; set; }
        public List<Teacher.Teacher> Substitues { get; set; }

        public abstract object Clone();

        public abstract int CompareTo(object obj);

        public abstract object DeepClone();
        public abstract object DeepClone2();

        public abstract int DeepCompareTo(object obj);


        
    }
}
