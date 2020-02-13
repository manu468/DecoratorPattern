using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{

    // this is a component class and 
    //The Component class contains functionality that will be shared with other Concrete Component 
    //classes. Having that in mind, let’s create the Concrete Components: Regular order


    public abstract class OrderBase
    {
        protected List<Product> products = new List<Product>
    {
        new Product {Name = "Phone", Price = 587},
        new Product {Name = "Tablet", Price = 800},
        new Product {Name = "PC", Price = 1200}
    };

        public abstract double CalculateTotalOrderPrice();
    }
}
