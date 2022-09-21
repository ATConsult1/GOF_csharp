using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning2022.gof.af
{
    
    // 2 families of products
    abstract class ProductA { 
        //.... product datas
        }
    abstract class ProductB { 
       }

    class ProductA1 : ProductA { }
    class ProductA2 : ProductA { }
    class ProductB1 : ProductB { }
    class ProductB2 : ProductB { }


    abstract class AbstractProductFactory {

        public abstract ProductA makeProductA();
        public abstract ProductB makeProductB();
    }

    class ConcreteFactory1 : AbstractProductFactory
    {
        public override ProductA makeProductA()
        {
            Console.WriteLine("ProductA1() ++");
            return new ProductA1();
        }

        public override ProductB makeProductB()
        {
            Console.WriteLine("ProductB1() ++");
            return new ProductB1();

        }
    }


    class ConcreteFactory2: AbstractProductFactory
    {
        public override ProductA makeProductA()
        {
            Console.WriteLine("ProductA2) ++");
            return new ProductA2();
        }

        public override ProductB makeProductB()
        {
            Console.WriteLine("ProductB2) ++");
            return new ProductB2();

        }
    }




  









}
