using FinalQuiz.Factory;
using FinalQuiz.Model;
using FinalQuiz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalQuiz.Handler
{
    public class CartHandler
    {
        public static List<Model.Cart> getCart(int user_id)
        {
            return CartRepository.getCartData(user_id);
        }
        public static CartDataSet getCartData(int user_id)
        {
            return CartRepository.getData(user_id);
        }
        public static bool addCart(int user_id, int product_id, int quantity)
        {
            Model.Cart cartStock = CartRepository.findCart(user_id, product_id);
            Product addProduct = ProductRepository.findProduct(product_id);
            int QuantityExist = quantity;
            if(cartStock != null)
            {
                QuantityExist += cartStock.Quantity;
            }
            if(QuantityExist <= addProduct.Stock)
            {
                Model.Cart cart = CartFactory.addCart(user_id, product_id, quantity);
                CartRepository.addCart(cart);
                return true;
            }
            return false;
        }
        public static bool deleteCart(int cart_id)
        {
            CartRepository.deleteCart(cart_id);
            return true;
        }
        public static bool checkout(String email)
        {
            int user_id = UserHandler.searchUser(email).UserId;
            //TransactionHandler.addTransaction(user_id); //Trans Handler
            List<Model.Cart> CheckoutProduct = getCart(user_id);
            foreach (Model.Cart cart in CheckoutProduct)
            {
                //ProductHandler.updateStock(.....) //Product Handler
            }
            deleteCart(user_id);
            return true;
        }
        protected static void deleteAllCart(int user_id)
        {
            CartRepository.deleteAllCart(user_id);
        }
    }
}