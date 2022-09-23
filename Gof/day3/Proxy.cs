using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace learning2022.gof.proxy
{

    abstract public class Subject
    {
        //..
        public abstract void Request();
    }


    public class RealSubject : Subject
    {
        public override void Request()
        {
            WriteLine("RealSubject request fired.");
        }
    }

    public class Proxy : Subject
    {
        private Subject? subj = null;

        public override void Request()
        {
            /// if(flags) ...
            /// 
            if(subj == null) subj = new RealSubject();  
            subj.Request();
        }
    }
}
