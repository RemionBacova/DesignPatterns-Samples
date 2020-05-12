using System.Collections.Generic;
using AbstractFactory_Object_Example.Interfaces;
using AbstractFactory_Object_Example.Models.Student;

namespace AbstractFactory_Object_Example
{
    class TestClass
    {
        private List<IStudent> Studentet = new List<IStudent>();

        public void GenerateStudents()
        {
            #region Sample Single Initialization
            IStudent Studenti1 = new MasterStudent
            {
                Type = "Master",
                Name = "St1Name",
                Surname = "St1Surname"
            };
            IStudent Studenti2 = new BachelorStudent
            {
                Type = "Bachelor",
                Name = "St2Name",
                Surname = "St2Surname"
            };

            Studentet.Add(Studenti1);
            Studentet.Add(Studenti2);
            #endregion

            #region Sample Group Initialization
            for (int i = 2; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Studentet.Add(new BachelorStudent
                    {
                        Type = "Master",
                        Name = "St" + i.ToString() + "Name",
                        Surname = "St" + i.ToString() + "Surname"
                    }); ; ;
                }
                else
                {
                    Studentet.Add(new MasterStudent
                    {
                        Type = "Bachelor",
                        Name = "St" + i.ToString() + "Name",
                        Surname = "St" + i.ToString() + "Surname"
                    });
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
