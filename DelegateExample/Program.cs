using System;

namespace DelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductFactory productFactory = new ProductFactory();
            Func<Product> funcPizza = new Func<Product>(productFactory.MakePizza);
            Func<Product> funcCar = new Func<Product>(productFactory.MakeCar);
            Logger logger = new Logger();
            Action<Product> actionLog = new Action<Product>(logger.Log);

            WarpFactory warpFactory = new WarpFactory();
            Box box1 = warpFactory.warp(funcPizza, actionLog); // return Pizza
            Box box2 = warpFactory.warp(funcCar, actionLog); // return Car
        }
    }
}
