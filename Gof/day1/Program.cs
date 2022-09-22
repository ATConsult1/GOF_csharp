// See https://aka.ms/new-console-template for more information

using learning2022.gof.af;
using learning2022.gof.ston;
using static System.Console;
using static andestech.learning2022.gof.Utils;
using System.Text;

namespace learning2022.gof
{

    class GofTest {

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