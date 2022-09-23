using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace learning2022.gof
{

    public abstract class Handler { 
    public Handler? Next { get; set; }

        public abstract void Handle(int n); 
    }

    public class Handler1 : Handler
    {
        public override void Handle(int n)
        {
            // ....
            if (n > 10 && n < 100) { ////
                WriteLine("++ Handler1 try to pass next.");
                Next?.Handle(n);
            }
            else WriteLine("-- End of Request: Handler1");
        }
    }

    public class Handler2 : Handler
    {
        public override void Handle(int n)
        {
            // ....
            if (n > 30 && n < 50)
            { ////
                WriteLine("++ Handler2 try to pass next.");
                Next?.Handle(n);
            }
            else WriteLine("-- End of Request: Handler2");
        }
    }


}
