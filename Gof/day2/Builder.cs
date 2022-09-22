using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning2022.gof.builder
{
    public abstract class Builder
    {
        public abstract void buildPart1();
        public abstract void buildPart2();
        //...
        public abstract  Product getResult();
    }

    public class Product {

        private ArrayList parts = new ArrayList(10);
        public ArrayList getParts() { return parts; } 

        public void Attach(string part)
        { 
          parts.Add(part);
        }
    }

    public class ConcreteBuilder : Builder
    {
        Product product;
        public ConcreteBuilder() {
            product = new Product();
        }

        public override void buildPart1()
        {
            product.Attach("part1");
        }

        public override void buildPart2()
        {
            product.Attach("part2");
        }

        public override Product getResult()
        {
            return product;
        }
    }

    class Director
    { 
       Builder builder;
       public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void BuildAll() {
            builder.buildPart1();
            builder.buildPart2();
            //....
        
        }


    }

}
