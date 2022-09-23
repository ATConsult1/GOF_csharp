using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace learning2022.gof.composite
{
    public abstract class Component
    {
        protected int Id { get; set; }

        public Component(int id)
        {
            Id = id;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Show();
    }


    public class Composite : Component
    {
        List<Component> childs = new List<Component>();

        public Composite(int id) : base(id)
        {
        }

        public override void Add(Component c)
        {
            childs.Add(c);
        }

        public override void Remove(Component c)
        {
            childs.Remove(c);
        }

        public override void Show()
        {
            WriteLine($"Composite Componet Id:{Id}");
            foreach (Component co in childs) co.Show();
        }
    }


    public class Leaf : Component
        {
            public Leaf(int id) : base(id)
            {
            }

            public override void Add(Component c)
            {
                throw new NotImplementedException();
            }

            public override void Remove(Component c)
            {
                throw new NotImplementedException();
            }

            public override void Show()
            {
                WriteLine($"Componet Id:{Id}");
            }
        }


    }




