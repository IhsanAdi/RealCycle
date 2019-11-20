using FinalQuiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalQuiz.Factory
{
    public class ProductFactory
    {
        public static Product createProduct(String productName, String category, int price, int stock, String description)
        {
            Product product = new Product();

            product.ProductName = productName;
            product.Category = category;
            product.Price = price;
            product.Stock = stock;
            product.Description = description;

            return product;
        }
    }
}