using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning2022.gof.ston
{
    internal class Singleton
    {
        private static Singleton obj;

        private Singleton() { }
        public static Singleton getInstance() {

            if (obj == null) obj = new Singleton();
            return obj;
        
        }
    }
}
