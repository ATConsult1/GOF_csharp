using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace learning2022.gof.decorator
{

    abstract class Decorator : Component {

        protected Component component;

        public Decorator(Component component)
        {
            this.component = component;
        }
    
        public override string greets()
        {
            if( component!= null) return component.greets();
            return "Hi";
        }

    }

    class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component component) : base(component)
        {        
        }

        public override string greets()
        {
            return $"<h1> {base.greets()} </h1>";
         }
    }




    abstract class Component {
        public abstract string greets();
        //...
    
    }

    class ConcreteComponent : Component {
        //....
        // method to decore
        public override string greets() {
            //...
            return "Make Smth method fired.";
        }
    }

    
}
