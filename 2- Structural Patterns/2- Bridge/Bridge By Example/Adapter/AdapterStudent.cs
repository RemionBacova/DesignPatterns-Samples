using Bridge_By_Example.Interfaces;
using Bridge_By_Example.Models.Student;
using Bridge_By_Example.Models.Student.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_By_Example.Adapter
{
    class AdapterStudent : IStudentList
    {
        private List<IStudent> Student = new List<IStudent>();

        public void AddStudent(IStudent student)
        {
            if(student.GetType() == typeof(MasterStudent))
            {
                Student.Add(student);
            }
            else if (student.GetType() == typeof(BachelorStudent))
            {
                Student.Add(transform(student));
            }
            else
            {
                throw new Exception();
            }
        }

        private MasterStudent transform (IStudent student)
        {
            MasterStudent _transformedStudent = new MasterStudent()
            {
                Type = "Master",
                Name = student.Name,
                Surname = student.Surname

            };
            return _transformedStudent;
        }

        public List<IStudent> GetStudents()
        {
            return Student;
        }
    }
}
