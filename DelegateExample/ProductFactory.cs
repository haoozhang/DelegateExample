using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateExample
{
    class ProductFactory
    {
        public Product MakePizza()
        {
            Product product = new Product();
            product.Name = "Pizza";
            product.Price = 10;
            return product;
        }

        public Product MakeCar()
        {
            Product product = new Product();
            product.Name = "Car";
            product.Price = 1000;
            return product;
        }
    }
}
