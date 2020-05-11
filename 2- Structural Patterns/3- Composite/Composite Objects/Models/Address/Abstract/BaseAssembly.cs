using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_Objects.Models.Address.Abstract
{
    public abstract class BaseAssembly
    {
        protected string Name;
        public BaseAssembly(string name)
        {
            Name = name;
        }

        public abstract void Add(BaseAssembly assembly);
        public abstract void Remove(BaseAssembly assembly);
        public abstract void WriteChildren();
    }
}
