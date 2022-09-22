using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace learning2022.gof.adapter
{

    public class Clent
    {
        public void Request(Target target)
        {
            target.Request();
        }
     
    }
    
    public class Adapter : Target
    {
        private Adaptee ad = new Adaptee();
        public override void Request()
        {
            //base.Request();
            ad.SpecificRequest();
        }

    }

    public class Target
    { 
      public virtual void Request()
        {
            WriteLine("Request on Targer class fired +++ ");
        }
    }

    public class Adaptee
    {
        public void SpecificRequest()
        {
            WriteLine("SpecificRequest on Adaptee class fired +++ ");
        }
    }


}
