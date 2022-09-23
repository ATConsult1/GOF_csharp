using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning2022.gof.memento
{
    public class Memento
    {
       public int state { get; private set; }
       public Memento(int state) { this.state = state; } 
    }

    class Caretaker {
        private List<Memento> mementos = new List<Memento>();
        public Caretaker add(Memento mem) { mementos.Add(mem); return this; }
        public Memento get(int i) => mementos.ElementAt(i);

    }

    public class Originator {

        public int state;
        public void setMemento(Memento mem) { state = mem.state; }
        public Memento CreateMem() => new Memento(state);
    
    }


}
