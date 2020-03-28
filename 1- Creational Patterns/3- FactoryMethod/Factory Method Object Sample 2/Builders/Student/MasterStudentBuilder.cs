using Factory_Method_Object_Sample_2.Builders.Student.Abstract;



namespace Factory_Method_Object_Sample_2.Builders.Student
{
    class MasterStudentBuilder : StudentBuilderAbstract
    {
        public override void BuildObjct()
        {
            _Student = new Models.Student.MasterStudent();
            SetType();
        }

        private void SetType()
        {
            _Student.Type = "Master";
        }

    }
}
