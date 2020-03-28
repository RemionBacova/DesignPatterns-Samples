using Factory_Method_Object_Sample_2.Builders.Student.Abstract;

namespace Factory_Method_Object_Sample_2.Builders.Student
{
    class BachelorStudentBuilder : StudentBuilderAbstract
    {
        public override void BuildObjct()
        {
            _Student = new Models.Student.BachelorStudent();
            SetType();
        }

        private void SetType()
        {
            _Student.Type = "Bachelor";
        }
    }
}
