// See https://aka.ms/new-console-template for more information

namespace learning2022.gof.af
{
    class GofTest {

        public static void Main(String[] args)
        {

            Console.WriteLine("Hello, GOF!");
            testAbstractFabric(new ConcreteFactory1());
            testAbstractFabric(new ConcreteFactory2());

        }

        private static ProductA productA;
        private static ProductB productB;

        static void testAbstractFabric(AbstractProductFactory factory) {

            productA = factory.makeProductA();
            productB = factory.makeProductB();


        }


  }
}