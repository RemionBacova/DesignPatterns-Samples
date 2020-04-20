using Bridge_By_Example.Interfaces;


namespace Bridge_By_Example.Director
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
