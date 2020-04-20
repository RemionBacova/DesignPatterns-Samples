using Bridge_By_Example.Factory;
using Bridge_By_Example.Interfaces;
using Bridge_By_Example.Models.Student.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_By_Example
{
    class TestClass
    {
        private List<IStudent> Studentet = new List<IStudent>();

        public void GenerateStudents()
        {

            #region Sample Single Initialization

            IStudent Student1 = FactoryStudents.CreateStudent(StudentType.Bachelor, 1);
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
