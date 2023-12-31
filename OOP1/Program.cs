﻿namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 1, CategoryId = 2, ProductName = "Kalem", UnitsInStock = 10, UnitPrice = 35 };

            //PascalCase    //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName); 

            productManager.Update( product2 );
            Console.WriteLine(product2.ProductName);
        }
    }
}