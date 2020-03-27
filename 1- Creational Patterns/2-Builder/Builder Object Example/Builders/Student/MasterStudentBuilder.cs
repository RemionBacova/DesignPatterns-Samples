using Builder_Object_Example.Builders.Student.Abstract;



namespace Builder_Object_Example.Builders.Student
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
