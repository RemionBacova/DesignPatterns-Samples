using Factory_Method_Object_Sample_2.Interfaces;

namespace Factory_Method_Object_Sample_2.Director
{
    class DirectorStdentBuilder
    {
        public IStudent Build(Interfaces.IStudentBuilder Builder, int i)
        {
            Builder.BuildObjct();
            Builder.SetProperties(i);
            return Builder.GetStudent();
        }
    }
}
