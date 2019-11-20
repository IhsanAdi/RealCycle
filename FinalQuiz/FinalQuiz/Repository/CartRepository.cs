using FinalQuiz.Handler;
using FinalQuiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalQuiz.Repository
{
    public class CartRepository
    {
        static Entities db = new Entities();

        public static List<Model.Cart> getCartData(int user_id)
        {
            return db.Carts.Where(x => x.UserId == user_id).ToList();
        }

        public static CartDataSet getData(int user_id)
        {
            CartDataSet ds = new CartDataSet();
            var dsCart = ds.Cart;
            List<Model.Cart> carts = getCartData(user_id);
            if(carts.Count > 0)
            {
                foreach (Model.Cart cart in carts)
                {
                    var cRow = dsCart.NewRow();
                    byte[] encds = System.Text.Encoding.UTF8.GetBytes(cart.Product.Picture);
                    cRow["Id"] = cart.Id;
                    cRow["UserId"] = cart.UserId;
                    cRow["ProductName"] = cart.Product.ProductName;
                    cRow["ProductPicture"] = "data:Image/png;base64, " + Convert.ToBase64String(encds);
                    cRow["ProductPrice"] = cart.Product.Price;
                    cRow["Quantity"] = cart.Quantity;
                    dsCart.Rows.Add(cRow);
                }
            }
            return ds;
        }
        public static Model.Cart findCart(int user_id, int product_id)
        {
            return db.Carts.Where(x => x.UserId == user_id && x.ProductId == product_id).FirstOrDefault();
        }
        public static Model.Cart findByCartId(int cart_id)
        {
            return db.Carts.Where(x => x.Id == cart_id).FirstOrDefault();
        }
        public static void addCart(Model.Cart cart)
        {
            Model.Cart validCart = findCart(cart.UserId, cart.ProductId);
            if(validCart != null)
            {
                validCart.Quantity += cart.Quantity;
            }else
            {
                db.Carts.Add(cart);
            }
            db.SaveChanges();
        }
        public static void deleteCart(int cart_id)
        {
            Model.Cart deleteCart = findByCartId(cart_id);
            db.Carts.Remove(deleteCart);
            db.SaveChanges();
        }
        public static void deleteAllCart(int user_id)
        {
            List<Model.Cart> removeCart = getCartData(user_id);
            db.Carts.RemoveRange(removeCart);
            db.SaveChanges();
        }
    }
}