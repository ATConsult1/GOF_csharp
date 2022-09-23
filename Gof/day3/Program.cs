using static System.Console;
using static andestech.learning2022.gof.Utils;
using System.Text;
using dec = learning2022.gof.decorator;
using prx = learning2022.gof.proxy;
using brd = learning2022.gof.bridge;
using cst = learning2022.gof.composite;
using learning2022.gof.bridge;
using learning2022.gof.composite;

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

            echo("Composite");
            testComposite();

            echo("Chain of Responsibilities");
            testCoR();

        }

        public static void testCoR() {
            Handler h1 = new Handler1();
            Handler h2 = new Handler2();
            h1.SuccessHandler = h2;
            h1.Handle(35);
            echo("handle 2", "+", 30);
            h1.Handle(25);
            echo("handle 3", "+", 30);
            h1.Handle(3000);

        }


        public static void testComposite() {
            cst.Component comp_0 = new cst.Composite(0); // root
            cst.Component comp_1 = new Leaf(1);          // 1st-level child final (leaf)
            cst.Component comp_3 = new Composite(300);   // 1st-level child composite

            comp_0.Add(comp_1);
            comp_0.Add(comp_3);
            comp_0.Show();
        
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
