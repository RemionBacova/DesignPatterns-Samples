using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_By_Example.Interfaces
{
    interface IStudentList
    {
        List<IStudent> GetStudents();
        void AddStudent(IStudent student);
    }
}
