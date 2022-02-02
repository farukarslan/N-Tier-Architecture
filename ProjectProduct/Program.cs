using BusinessLayer;
using BusinessLayer.ValidationRules;
using EntityLayer.Entities;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryManager categoryManager = new CategoryManager();
            ProductManager productManager = new ProductManager();

            //----------- Category Transactions -----------
            //List Data
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine("ID: " + item.CategoryID + " - Category Name: " + item.CategoryName);
            }

            //Add Data
            //Category category = new Category();
            //category.CategoryName = "Halılar";
            //categoryManager.BLAdd(category);

            //Using FluentValidation for Adding Data
            Category ct = new Category();
            ct.CategoryName = "CategoryCategoryCategoryCategory";
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult result = categoryValidator.Validate(ct);
            if (result.IsValid)
            {
                categoryManager.BLAdd(ct);
                Console.WriteLine("Category added.");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    Console.WriteLine(item.ErrorMessage);
                }
            }

            //Delete Data
            //categoryManager.BLDelete(5); // parameter --> id

            //Update Data
            //Category c = new Category();
            //c.CategoryID = 3;
            //c.CategoryName = "Bilgisayar Bileşenleri";
            //categoryManager.BLUpdate(c);


            //----------- Product Transactions -----------
            //List Data
            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine("ID: " + item.ProductID + " - Product Name: " + item.ProductName + " - Stock: " +
                    item.Stock + " - Category: " + item.Category.CategoryName);
            }

            Console.WriteLine("\n----------------\n");

            //List By Name
            string productName = "SSD";
            foreach (var item in productManager.GetByName(productName))
            {
                Console.WriteLine("ID: " + item.ProductID + " - Product Name: " + item.ProductName + " - Stock: " +
                    item.Stock + " - Category: " + item.Category.CategoryName);
            }

            Console.WriteLine();



            Console.Read();
        }
    }
}
