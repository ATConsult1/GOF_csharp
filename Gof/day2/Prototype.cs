using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning2022.gof.proto
{
    public abstract class Data : ICloneable
    {
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }


    public abstract class Prototype
    {
        public string Name { get; private set; }
        public Prototype(string Name)
        {
            this.Name = Name;
        }

        public abstract Prototype Clone();

    }

    public class ConcretePrototype: Prototype
    {
         public ConcretePrototype(string Name): base(Name)
        {        }

        public override Prototype Clone() {
            
            return new ConcretePrototype(Name);
        
        }

    }


}
