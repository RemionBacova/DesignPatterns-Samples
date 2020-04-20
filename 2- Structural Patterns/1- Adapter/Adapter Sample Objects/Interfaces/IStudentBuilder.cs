

using Adapter_Sample_Objects.Interfaces;

namespace Adapter_Sample_Objects.Interfaces
{
    public interface IStudentBuilder
    {
        public void BuildObjct();
        public void SetProperties(int i);
        public IStudent GetStudent();
    }
}
