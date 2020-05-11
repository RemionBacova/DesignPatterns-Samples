using Composite_Objects.Models.Address.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Objects.Models.Address
{
    public class Leaf: BaseAssembly
    {

        public Leaf(string name) : base(name)
        {
        }
        public override void Add(BaseAssembly assembly)
        {
                Console.WriteLine("Leaf element cannot have dependencies!");
        }

        public override void Remove(BaseAssembly assembly)
        {
            Console.WriteLine("Leaf element has no dependencies!");
        }

        public override void WriteChildren()
        {
            Console.WriteLine("------------------------------------------------Element----- " + Name + "---- of type Leaf--");
            
            Console.WriteLine("------------------------------------------------End of Element----- " + Name + "---- of type Leaf--");
        }
    }
}
