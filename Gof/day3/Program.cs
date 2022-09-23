using static System.Console;
using static andestech.learning2022.gof.Utils;
using System.Text;
using dec = learning2022.gof.decorator;
using prx = learning2022.gof.proxy;
using brd = learning2022.gof.bridge;
using cst = learning2022.gof.composite;
using en = learning2022.gof.enumerator;
using it = learning2022.gof.iterator;
using obs = learning2022.gof.observer;
using learning2022.gof.bridge;
using learning2022.gof.composite;
using learning2022.gof.iterator;
using System.Collections;

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

            echo("Test dotnet Enumerator");
            testEnumerator();

            echo("Iterator");
            testIterator();

            echo("Observer");
            testObserver();


        }

        public static void testObserver() {
            obs.Subject subj = new obs.Subject();
            subj.AddObserver(new obs.ConcreteObserver())
                .AddObserver(new obs.ConcreteObserver())
                .AddObserver(new obs.ConcreteObserver())
                .AddObserver(new obs.ConcreteObserver())
                .AddObserver(new obs.ConcreteObserver());

            subj.NotifyAll();
        }


        public static void testIterator() {
            Aggregate aggregate = new ConcreteAggregate();
            Iterator iterator = aggregate.CreateIterator();

            object data = iterator.First(); WriteLine(data);

            while (!iterator.IsDone())
            { 
             data = iterator.Next();
             WriteLine(data);
            }

            //---------------------------
            List<string> items = new List<string>(new string[] { "DATA1", "D2", "E22" });
           
            
    }


        public static void testCoR() {
            Handler h1 = new Handler1();
            Handler h2 = new Handler2();
            h1.Next = h2;
            h1.Handle(35);
            echo("handle 2", "+", 30);
            h1.Handle(25);
            echo("handle 3", "+", 30);
            h1.Handle(3000);

        }

        public static void testEnumerator()
        {
            foreach (int i in new en.Data()) Write($"{i}, "); WriteLine();
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
