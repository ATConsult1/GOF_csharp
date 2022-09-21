// See https://aka.ms/new-console-template for more information

namespace learning2022.gof
{
    class GofTest {

        public static void Main(String[] args)
        {

            Console.WriteLine("Hello, GOF!");
            testFabricMethod();

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