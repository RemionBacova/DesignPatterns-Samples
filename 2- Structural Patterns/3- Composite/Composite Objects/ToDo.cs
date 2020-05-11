using Composite_Objects.Models.Address;
using Composite_Objects.Models.Address.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Objects
{
    public class ToDo
    {
        public Models.Address.Abstract.BaseAssembly PlantTree(string name)
        {
            return new Models.Address.Root( name);
        }

        public Models.Address.Abstract.BaseAssembly Populate(Models.Address.Abstract.BaseAssembly root)
        {
            for(int i = 0; i < 5; i ++)
            {
                Branch x = new Branch("Name " + i.ToString());
                for(int j = 0; j < 5; j++)
                {
                    x.Add(new Leaf("Name " + j.ToString()));
                }
                root.Add(x);
            }
            return root;
        }

    }
}
