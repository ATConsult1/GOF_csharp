using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning2022.gof
{
    abstract class Product { 
        //.... product datas
        }

    abstract class ProductCreator {

        public abstract Product makeProduct();
    }

    class ProductA : Product { }

    class ProductB : Product { }

    class ProductCreatorA : ProductCreator
    {
        public override Product makeProduct()
        {
           Console.WriteLine("ProductA() +++ ");
           return new ProductA();
        }
    }

    class ProductCreatorB : ProductCreator
    {
        public override Product makeProduct()
        {
            Console.WriteLine("ProductB() +++ ");
            return new ProductB();
        }

    }

    enum Products {A, B}










}
