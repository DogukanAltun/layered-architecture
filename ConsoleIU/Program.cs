using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleIU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager _productManager = new ProductManager(new InMemoryProductDal());

            foreach (var product in _productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
