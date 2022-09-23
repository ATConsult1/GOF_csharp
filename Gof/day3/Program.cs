using static System.Console;
using static andestech.learning2022.gof.Utils;
using System.Text;
using dec = learning2022.gof.decorator;
using prx = learning2022.gof.proxy;
using brd = learning2022.gof.bridge;
using learning2022.gof.bridge;

namespace learning2022.gof
{

    class GofTest
    {
            public static void Main(String[] args)
        {
            Console.WriteLine("GOF patterns test #2");

            echo("Decorator");
            testDecorator();

            echo("Proxy");
            testProxy();

            echo("Bridge");
            testBridge();

            echo("dotnet Strem examples");
            testDotNetDecors();
        }


        public static void testDotNetDecors() {

            using (FileStream fs = new FileStream("./data.txt", FileMode.Append))
            {
               fs.Write(Encoding.UTF8.GetBytes($"Date: {DateTime.Now}\n"));
            }


            using (BinaryWriter bw = new BinaryWriter(new FileStream("./data.bin", FileMode.Create)))
            {
                bw.Write(123456789123L);
                bw.Write(123456789123L);
            }

         
        
        }


        public static void testBridge() {

            brd.Abstraction abs = new brd.RefinedAbstraction(new brd.ConcreteImplementor1());
            abs.Operation();   
            
        
        }

        public static void testProxy() {
            prx.Subject subj = new prx.Proxy();
            subj.Request();
        
        }

        public static void testDecorator() {

            dec.Component comp1 = new dec.ConcreteComponent();
            WriteLine(comp1.greets());

            dec.Component comp2 = new dec.ConcreteDecoratorA(new dec.ConcreteComponent());  
            WriteLine(comp2.greets());

        }

    }
}
