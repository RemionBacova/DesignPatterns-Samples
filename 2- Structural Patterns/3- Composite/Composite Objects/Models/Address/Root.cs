using Composite_Objects.Models.Address.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Objects.Models.Address
{
    public class Root : BaseAssembly
    {
        private List<BaseAssembly> elements = new List<BaseAssembly>();
        public Root(string name) : base(name)
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
                Console.WriteLine("Root element cannot depend on antother root!");
            }
           
        }

        public override void Remove(BaseAssembly assembly)
        {
            elements.Remove(assembly);
        }

        public override void WriteChildren()
        {
            Console.WriteLine("----------------Element----- " + Name + "---- of type ROOT--");
            //write all list and call write for every element
            foreach (BaseAssembly assembly in elements)
            {
                assembly.WriteChildren();
            }
            Console.WriteLine("----------------End of Element----- " + Name + "---- of type ROOT--");
        }
    }
}
