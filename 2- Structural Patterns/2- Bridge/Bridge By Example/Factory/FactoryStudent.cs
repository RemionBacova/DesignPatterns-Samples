

using Bridge_By_Example.Builders.Student;
using Bridge_By_Example.Interfaces;
using Bridge_By_Example.Models.Student.Types;

namespace Bridge_By_Example.Factory
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
