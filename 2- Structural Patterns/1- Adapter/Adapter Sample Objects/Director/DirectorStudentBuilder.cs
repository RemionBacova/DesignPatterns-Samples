using Adapter_Sample_Objects.Interfaces;


namespace Adapter_Sample_Objects.Director
{
    class DirectorStdentBuilder
    {
        public IStudent Build(IStudentBuilder Builder, int i)
        {
            Builder.BuildObjct();
            Builder.SetProperties(i);
            return Builder.GetStudent();
        }
    }
}
