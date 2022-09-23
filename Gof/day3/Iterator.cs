using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning2022.gof.iterator
{
   public abstract class Iterator
    {
        public abstract object Next();
        public abstract object First();
        public abstract bool IsDone();
        public abstract object CurrentObject();
    }

    public abstract class Aggregate {
        public abstract Iterator CreateIterator();
        public abstract object this[int i] { get; set; }
        public abstract int Count { get; }
    }

    public class ConcreteAggregate : Aggregate
    {
        private ArrayList items = new ArrayList(new string[] {"DATA1","D2","E22"});

        public override object this[int i]
        { get => items[i];
          set => items.Insert(i, value); }

        public override int Count { get => items.Count; }

        public override Iterator CreateIterator() => new ConcreteIterator(this);
       
    }

    public class ConcreteIterator : Iterator
    {
        private Aggregate aggregate;
        private int index;

        public ConcreteIterator(Aggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public override object CurrentObject() => aggregate[index];
        public override object First() => aggregate[0];
        public override bool IsDone() => index >= aggregate.Count;  

        public override object Next()
        {
            index++;
            object? o = null;

            if (index < aggregate.Count) o=aggregate[index];
            return o;

        }
    }




}
