using FinalQuiz.Model;
using FinalQuiz.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FinalQuiz.Handler
{
    public class ProductHandler
    {
        public static List<Product> get()
        {
            return ProductRepository.get().ToList();
        }
        //public static List<Product> filteredproduct()
        //{

        //}
        //public static List<Product> get()
        //{

        //}
        //public static List<Product> getproduct()
        //{

        //}
        public static bool addProduct(Product product)
        {
            ProductRepository.addProduct(product);
            return true;
        }
        public static bool updateProduct(String productName, String category, int price, int stock, String picture, String description)
        {
            ProductRepository.updateProduct(productName, category, price, stock, picture, description);
            return true;
        }
        public static bool deleteProduct(String name)
        {
            ProductRepository.deleteProduct(name);
            return true;
        }

    }
}

//Transaction semua controller