using static System.Console;
using static andestech.learning2022.gof.Utils;
using System.Text;
using learning2022.gof.builder;
using learning2022.gof.proto;
using ad = learning2022.gof.adapter;

namespace learning2022.gof
{

    class GofTest
    {
            public static void Main(String[] args)
        {
            Console.WriteLine("GOF patterns test #2");

            echo("Builder");
            Builder builder = new ConcreteBuilder();
            Director dir = new Director(builder);
            dir.BuildAll();
            Product product = builder.getResult();
            foreach (string part in product.getParts()) WriteLine(part);

            echo("Prototype");
            Prototype proto = new ConcretePrototype("My Data");
            Prototype result = proto.Clone();
            WriteLine($"{proto.GetHashCode()}:{proto.Name} --- {result.GetHashCode()}:{result.Name}");

            echo("Adapter");
            ad.Clent client = new ad.Clent();
            client.Request(new ad.Target());
            client.Request(new ad.Adapter());

        }
    }
}
