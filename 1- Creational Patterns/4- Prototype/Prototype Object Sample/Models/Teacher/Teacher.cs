using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_Object_Sample.Models.Teacher
{
    public class Teacher : IComparable, ICloneable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }

        public object Clone()
        {
            return new Teacher()
            {
                Name = this.Name,
                Surname = this.Surname,
                Title = this.Title
            };
        }

        public int  CompareTo(object obj)
        {
            if(obj is Teacher)
            {
                if ((obj as Teacher).Name.Equals(this.Name) && (obj as Teacher).Surname.Equals(this.Surname)) return 1;
                else return 0;
            }
            else return 0;
        }
    }
}
