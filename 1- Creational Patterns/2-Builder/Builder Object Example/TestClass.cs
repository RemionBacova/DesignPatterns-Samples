using Builder_Object_Example.Builders.Student;
using Builder_Object_Example.Interfaces;
using System.Collections.Generic;

namespace Builder_Object_Example
{
    class TestClass
    {
        private List<IStudent> Studentet = new List<IStudent>();

        public void GenerateStudents()
        {
            Director.DirectorStdentBuilder director = new Director.DirectorStdentBuilder();
            IStudentBuilder studentBuilder;
            #region Sample Single Initialization

            studentBuilder = new BachelorStudentBuilder();
            Studentet.Add(director.Build(studentBuilder, 1));

            studentBuilder = new MasterStudentBuilder();
            Studentet.Add(director.Build(studentBuilder, 2));

            #endregion

            #region Sample Group Initialization

            for (int i = 3; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    studentBuilder = new BachelorStudentBuilder();
                }
                else
                {
                    studentBuilder = new MasterStudentBuilder();
                }
                Studentet.Add(director.Build(studentBuilder, i));
            }
            #endregion
        }

        public List<IStudent> ReturnStudents()
        {
            return this.Studentet;
        }
    }
}
