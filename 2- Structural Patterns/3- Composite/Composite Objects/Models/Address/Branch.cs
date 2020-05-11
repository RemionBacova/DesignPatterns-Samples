using Composite_Objects.Models.Address.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Objects.Models.Address
{
    public class Branch : BaseAssembly
    {
        private List<BaseAssembly> elements = new List<BaseAssembly>();
        public Branch(string name) : base(name)
        {
        }
        public override void Add(BaseAssembly assembly)
        {
            //if assembly is not root add else throw error
            if (assembly.GetType() != typeof(Root))
            {
                elements.Add(assembly);
            }
            else
            {
                Console.WriteLine("Root element cannot depend on a branch!");
            }
        }

        public override void Remove(BaseAssembly assembly)
        {
            //remove assembly 
                elements.Remove(assembly);
        }

        public override void WriteChildren()
        {
            Console.WriteLine("--------------------------------Element----- " + Name + "---- of type Branch--");
            //write all list and call write for every element
            foreach (BaseAssembly assembly in elements)
            {
                assembly.WriteChildren();
            }
            Console.WriteLine("--------------------------------End of Element----- " + Name + "---- of type Branch--");
        }
    }
}
