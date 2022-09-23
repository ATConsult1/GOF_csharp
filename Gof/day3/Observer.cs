using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace learning2022.gof.observer

{
    public abstract class Observer
    {
        public abstract void Update();
    }

    public class ConcreteObserver : Observer
    {
        public override void Update()
        {
            WriteLine($"Update on observer {this.GetHashCode()}");
        }
    }

    //---------------------------------------

    public class Subject{
        private List<Observer> observers;// = new List<Observer>();
        public Subject() {
            observers = new List<Observer>();
        }

        public Subject AddObserver(Observer o) {
            observers.Add(o);
            return this;
        }

        public Subject RemoveObserver(Observer o)
        {
            observers.Remove(o);
            return this;
        }

        public void NotifyAll()
        {
            foreach (Observer o in observers) o.Update();
        }

    }





}
