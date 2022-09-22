// See https://aka.ms/new-console-template for more information

using learning2022.gof.af;
using learning2022.gof.ston;
using static System.Console;
using System.Text;

namespace learning2022.gof
{
    class GofTest {


        private static string multString(string s, int n = 1)
        {
            StringBuilder sb =new StringBuilder();
            for(int i=1; i<=n; i++) sb.Append(s);
            return sb.ToString();
        }

        private static void echo(string? s = null, string ch = "-", int N = 80)
        {
            if (N <= 0 || N > 120) N = 70;
            if (s == null) { WriteLine(ch, N); return; }
            s = s.Substring(0, N);

            int L = s.Length;
            int chL= ch.Length;
            string half = multString(ch, (N - L)/2/chL);
           
            if (N - L >= 4*chL) {WriteLine($"{half} {s} {half}");}
            else WriteLine(s);
        }

        public static void Main(String[] args)
        {
            Console.WriteLine("GOF patterns test #1");

            echo("Fabric method");
            testFabricMethod();
            
            echo("Abstract Fabric");
            testAbstractFabric(new ConcreteFactory1());
            testAbstractFabric(new ConcreteFactory2());
            
            echo("Singleton");
            testSingleton();
        }

        static void testSingleton()
        {
            Singleton s1 = Singleton.getInstance();
            Singleton s2 = Singleton.getInstance();

            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
        }

        private static af.ProductA productA;
        private static af.ProductB productB;

        static void testAbstractFabric(af.AbstractProductFactory factory)
        {
            productA = factory.makeProductA();
            productB = factory.makeProductB();
        }


        static void testFabricMethod() {

            new ProductCreatorA().makeProduct();
            new ProductCreatorB().makeProduct();

            Products products = Products.A;

            switch (products) { 
            
            case Products.A:
                    new ProductCreatorA().makeProduct();
                    break;

            case Products.B:
                    new ProductCreatorB().makeProduct();
                    break;

                default: break;        
            }
        }
  }
}