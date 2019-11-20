using FinalQuiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalQuiz.Repository
{
    public class ProductRepository
    {
        public static List<Product> get()
        {
            Entities db = new Entities();
            return db.Products.ToList();
        }

        public static List<Product> getBike()
        {
            Entities db = new Entities();
            return db.Products.Where(x => x.Category == "Bike").ToList();
        }

        public static List<Product> getClothing()
        {
            Entities db = new Entities();
            return db.Products.Where(x => x.Category == "Clothing").ToList();
        }

        public static List<Product> getAccessories()
        {
            Entities db = new Entities();
            return db.Products.Where(x => x.Category == "Accessories").ToList();
        }

        static Entities db = new Entities();


        public static void addProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public static Product searchProduct(String productName)
        {
            Product product = db.Products.Where(x => x.ProductName.Equals(productName)).FirstOrDefault();
            return product;
        }

        public static Product findProduct(String name)
        {
            Product product = db.Products.Find(name);
            return product;
        }

        public static Product findProduct(int id)
        {
            return db.Products.SingleOrDefault(x => x.ProductId == id);
        }

        public static List<Product> getProduct(int id)
        {
            Entities db = new Entities();
            return db.Products.Where(x => x.ProductId == id).ToList();
        }


        public static void deleteProduct(String name)
        {
            Product product = searchProduct(name);
            db.Products.Remove(product);
            db.SaveChanges();
        }

        public static void updateProduct(String productName, String category, int price, int stock, String picture, String description)
        {
            Product product = searchProduct(productName);
            if (product != null)
            {
                product.Category = category;
                product.Price = price;
                product.Stock = stock;
                product.Picture = picture;
                product.Description = description;
            }
            db.SaveChanges();
        }
    }
}