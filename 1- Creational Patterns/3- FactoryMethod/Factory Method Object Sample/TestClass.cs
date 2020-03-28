using FactoryMethod_Object_Example.Interfaces;
using FactoryMethod_Object_Example.Factory;
using FactoryMethod_Object_Example.Models.Student.Types;
using System.Collections.Generic;

namespace Factory_Method_Object_Sample
{
    class TestClass
    {
        private List<IStudent> Studentet = new List<IStudent>();

        public void GenerateStudents()
        {
            #region Sample Single Initialization
            IStudent Studenti1 = FactoryStudent.CreateStudent(StudentType.Bachelor);
            Studenti1.Name = "St1Name";
            Studenti1.Surname = "St1Surname";
            IStudent Studenti2 = FactoryStudent.CreateStudent(StudentType.Master);
            Studenti2.Name = "St2Name";
            Studenti2.Surname = "St2Surname";

            Studentet.Add(Studenti1);
            Studentet.Add(Studenti2);
            #endregion

            #region Sample Group Initialization
            for (int i = 2; i < 100; i++)
            {
                IStudent X;
                if (i % 2 == 0)
                {
                    X = FactoryStudent.CreateStudent(StudentType.Bachelor);
                }
                else
                {
                    X = FactoryStudent.CreateStudent(StudentType.Master);
                }
                X.Name = "St" + i.ToString() + "Name";
                X.Surname = "St" + i.ToString() + "Surname";
                Studentet.Add(X);
            }
            #endregion
        }

        public List<IStudent> ReturnStudents()
        {
            return this.Studentet;
        }
    }
}
