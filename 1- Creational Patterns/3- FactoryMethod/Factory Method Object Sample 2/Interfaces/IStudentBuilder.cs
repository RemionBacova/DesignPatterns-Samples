

namespace Factory_Method_Object_Sample_2.Interfaces
{
    public interface IStudentBuilder
    {
        public void BuildObjct();
        public void SetProperties(int i);
        public IStudent GetStudent();
    }
}
