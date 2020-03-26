using AbstractFactory_Object_Example.Models.Student.Abstract;

namespace AbstractFactory_Object_Example.Models.Student
{
    class MasterStudent : StudentAbstract
    {
        private string _Type = "";

        public override string Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                if (value == "Master")
                    this._Type = value;
                else
                {
                    //throw error 
                }
            }
        }
    }
}
