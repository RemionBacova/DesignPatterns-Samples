

using Bridge_By_Example.Interfaces;

namespace Bridge_By_Example.Interfaces
{
    public interface IStudentBuilder
    {
        public void BuildObjct();
        public void SetProperties(int i);
        public IStudent GetStudent();
    }
}
