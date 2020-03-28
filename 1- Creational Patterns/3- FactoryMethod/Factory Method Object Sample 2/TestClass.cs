using Factory_Method_Object_Sample_2.Builders.Student;
using Factory_Method_Object_Sample_2.Factory;
using Factory_Method_Object_Sample_2.Interfaces;
using Factory_Method_Object_Sample_2.Models.Student.Types;
using System.Collections.Generic;

namespace Factory_Method_Object_Sample_2
{
    class TestClass
    {
        private List<IStudent> Studentet = new List<IStudent>();

        public void GenerateStudents()
        {
           
            #region Sample Single Initialization

            IStudent Student1 =  FactoryStudents.CreateStudent(StudentType.Bachelor,1);
            IStudent Student2 = FactoryStudents.CreateStudent(StudentType.Master, 2);

            #endregion

            #region Sample Group Initialization

            for (int i = 3; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Studentet.Add(FactoryStudents.CreateStudent(StudentType.Bachelor, i));
                }
                else
                {
                    Studentet.Add(FactoryStudents.CreateStudent(StudentType.Master, i));
                }

            }
            #endregion
        }

        public List<IStudent> ReturnStudents()
        {
            return this.Studentet;
        }
    }
}
