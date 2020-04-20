

using Adapter_Sample_Objects.Builders.Student;
using Adapter_Sample_Objects.Interfaces;
using Adapter_Sample_Objects.Models.Student.Types;

namespace Adapter_Sample_Objects.Factory
{
    class FactoryStudents
    {
        public static IStudent CreateStudent(StudentType _StudentType, int i)
        {
            Director.DirectorStdentBuilder director = new Director.DirectorStdentBuilder();
            IStudentBuilder studentBuilder;
            switch (_StudentType)
            {
                case StudentType.Bachelor:
                    {
                        studentBuilder = new BachelorStudentBuilder();
                        return director.Build(studentBuilder, i);
                    }
                case StudentType.Master:
                default:
                    {
                        studentBuilder = new MasterStudentBuilder();
                        return director.Build(studentBuilder, i);
                    }
            }
        }
    }
}
