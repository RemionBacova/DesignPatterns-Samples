using Builder_Object_Example.Builders.Student.Abstract;

namespace Builder_Object_Example.Builders.Student
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
