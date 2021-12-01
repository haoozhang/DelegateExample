using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateExample
{
    class Logger
    {
        public void Log(Product product)
        {
            Console.WriteLine("Product {0} created at {1}, price is {2}.", product.Name, DateTime.UtcNow, product.Price);
        }
    }
}
