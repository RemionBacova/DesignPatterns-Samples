using Adapter_Sample_Objects.Builders.Student.Abstract;

namespace Adapter_Sample_Objects.Builders.Student
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
