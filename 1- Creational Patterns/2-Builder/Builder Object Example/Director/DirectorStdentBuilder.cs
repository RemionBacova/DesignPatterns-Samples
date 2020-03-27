using Builder_Object_Example.Interfaces;

namespace Builder_Object_Example.Director
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
