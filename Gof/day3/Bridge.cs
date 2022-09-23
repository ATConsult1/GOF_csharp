using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace learning2022.gof.bridge
{

    public abstract class Abstraction
    {
        protected Implementor implementor { get; set; }
        public Abstraction(Implementor implementor)
        {
            this.implementor = implementor;
        }

        public abstract void Operation();
    }

    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(Implementor implementor) : base(implementor)
        {
        }

        public override void Operation()
        {
            implementor.Operation();
        }

    }


    public abstract class Implementor
    {
        public abstract void Operation();
    }

    public class ConcreteImplementor1 : Implementor
    {
        public override void Operation() {
            WriteLine("ConcreteImplementor1 operation fired.");
        }
    }


}
