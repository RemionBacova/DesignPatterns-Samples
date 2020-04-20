using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Sample_Objects.Interfaces
{
    interface IStudentList
    {
        List<IStudent> GetStudents();
        void AddStudent(IStudent student);
    }
}
