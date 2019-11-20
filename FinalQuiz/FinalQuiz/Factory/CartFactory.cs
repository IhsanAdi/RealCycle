using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalQuiz.Factory
{
    public class CartFactory
    {
        public static Model.Cart addCart(int userId, int productId, int quantity)
        {
            Model.Cart cart = new Model.Cart();
            cart.UserId = userId;
            cart.ProductId = productId;
            cart.Quantity = quantity;
            return cart;

        }
    }
}