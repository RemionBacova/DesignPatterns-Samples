using Composite_Objects.Models.Address.Abstract;
using System;

namespace Composite_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDo toDo = new ToDo();

            BaseAssembly Items = toDo.Populate( toDo.PlantTree("Pema Qershise"));

            Items.WriteChildren();

        }
    }
}
