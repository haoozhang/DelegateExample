using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateExample
{
    class WarpFactory
    {
        // receive Delegate parameter
        public Box warp(Func<Product> getProduct, Action<Product> logCallback)
        {
            Box box = new Box();
            Product product = getProduct.Invoke();
            if (product.Price > 50)
            {
                logCallback.Invoke(product);
            }
            box.Product = product;
            return box;
        }
    }
}
