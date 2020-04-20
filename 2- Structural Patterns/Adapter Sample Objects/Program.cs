using Adapter_Sample_Objects.Adapter;
using Adapter_Sample_Objects.Interfaces;
using System;
using System.Collections.Generic;

namespace Adapter_Sample_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();
            testClass.GenerateStudents();

            List<IStudent> list =   testClass.ReturnStudents();
            // list contains list of master students and bachelor students

            AdapterStudent adapterStudent = new Adapter.AdapterStudent();

            foreach(IStudent student in list)
            {
                adapterStudent.AddStudent(student);
            }

            List<IStudent> masterStudents = adapterStudent.GetStudents();

            foreach(IStudent mStudent in masterStudents)
            {
                Console.WriteLine(mStudent.Type);
            }
            //all of the type of students should be student, we transformed a list of combined master and bachelor students to a list of masterstudents




        }
    }
}