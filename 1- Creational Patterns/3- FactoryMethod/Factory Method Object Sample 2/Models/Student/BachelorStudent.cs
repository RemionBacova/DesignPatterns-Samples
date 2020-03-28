using Factory_Method_Object_Sample_2.Models.Student.Abstract;

namespace Factory_Method_Object_Sample_2.Models.Student
{
    class BachelorStudent : StudentAbstract
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
                if (value == "Bachelor")
                    this._Type = value;
                else
                {
                    //throw error 
                }
            }
        }

    }
}
