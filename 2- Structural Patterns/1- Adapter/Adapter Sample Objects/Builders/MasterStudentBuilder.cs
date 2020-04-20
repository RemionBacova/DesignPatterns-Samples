using Adapter_Sample_Objects.Builders.Student.Abstract;



namespace Adapter_Sample_Objects.Builders.Student
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
