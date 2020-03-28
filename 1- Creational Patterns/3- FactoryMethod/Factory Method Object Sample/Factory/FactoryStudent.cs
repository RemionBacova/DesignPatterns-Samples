using FactoryMethod_Object_Example.Interfaces;
using FactoryMethod_Object_Example.Models.Student;
using FactoryMethod_Object_Example.Models.Student.Types;

namespace FactoryMethod_Object_Example.Factory
{
    class FactoryStudent
    {
        public static IStudent CreateStudent(StudentType _StudentType)
        {
            switch (_StudentType)
            {
                case StudentType.Bachelor:
                    return new BachelorStudent();
                case StudentType.Master:
                default:
                    return new MasterStudent();
            }
        }
    }
}
