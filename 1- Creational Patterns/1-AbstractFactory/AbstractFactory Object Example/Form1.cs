
using System.Collections.Generic;
using System.Windows.Forms;


namespace AbstractFactory_Object_Example
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

            TestClass a = new TestClass();
            a.GenerateStudents();
            string kthimi = "";
            List<Interfaces.IStudent> students = a.ReturnStudents();

            foreach (Interfaces.IStudent student in students)
            {
                kthimi +=  (student.Name + student.Surname)+ "\n";
            }

            MessageBox.Show(kthimi);
        }

        
    }
}
