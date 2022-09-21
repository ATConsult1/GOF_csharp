using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning2022.gof.ston
{

    class TestSton {
        public static void Main(String[] vars) {

            Singleton s1 = Singleton.getInstance();
            Singleton s2 = Singleton.getInstance();

            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());

        }
    }
    
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
