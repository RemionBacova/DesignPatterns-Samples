using Factory_Method_Object_Sample_2.Builders.Student;
using Factory_Method_Object_Sample_2.Interfaces;
using Factory_Method_Object_Sample_2.Models.Student.Types;

namespace Factory_Method_Object_Sample_2.Factory
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
