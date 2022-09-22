using static System.Console;
using static andestech.learning2022.gof.Utils;
using System.Text;
using learning2022.gof.builder;

namespace learning2022.gof
{

    class GofTest
    {
            public static void Main(String[] args)
        {
            Console.WriteLine("GOF patterns test #1");

            echo("Builder");
            Builder builder = new ConcreteBuilder();
            Director dir = new Director(builder);
            dir.BuildAll();
            Product product = builder.getResult();
            foreach (string part in product.getParts()) WriteLine(part);

        }
    }
}
