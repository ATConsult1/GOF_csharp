using static System.Console;
using static andestech.learning2022.gof.Utils;
using System.Text;
using dec = learning2022.gof.decorator;
namespace learning2022.gof
{

    class GofTest
    {
            public static void Main(String[] args)
        {
            Console.WriteLine("GOF patterns test #2");

            echo("Decorator");
            testDecorator();
        
        }


        public static void testDecorator() {

            dec.Component comp1 = new dec.ConcreteComponent();
            WriteLine(comp1.greets());

            dec.Component comp2 = new dec.ConcreteDecoratorA(new dec.ConcreteComponent());  
            WriteLine(comp2.greets());

        }

    }
}
