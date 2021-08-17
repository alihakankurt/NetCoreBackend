using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
        }

        private static void ProductTest()
        {
            var manager = new ProductManager(new EfProductDal());
            var result = manager.GetByProductId(2);
            Console.WriteLine(result.Success);
            Console.WriteLine(result.Message);
            Console.WriteLine(result.Data.ProductName);
        }

        static void CategoryTest()
        {
            var manager = new CategoryManager(new EfCategoryDal());
            var result = manager.GetByCategoryId(1);
            Console.WriteLine(result.Success);
            Console.WriteLine(result.Message);
            Console.WriteLine(result.Data.CategoryName);
        }
    }
}
