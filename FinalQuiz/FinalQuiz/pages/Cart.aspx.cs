using FinalQuiz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalQuiz
{
    public partial class Cart : System.Web.UI.Page
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //....
        }

        //public void viewData()
        //{
            ////
            //HttpCookie cookie = new HttpCookie("TempCookie");
           // cookie["ProductName"] = ProductName
         //   cookie.Values.Add("address", address);
        
            //get the values out
       //     string name = Request.Cookies["TempCookies"]["name"];
     //       string address = Request.Cookies["TempCookies"]["address"];
   //     }

        //protected void deleteBtn_Click(object sender, EventArgs e)
        //{
          //  ProductRepository.deleteProduct();
        //}

        //protected void CheckoutBtn_Click(object sender, EventArgs e)
        //{
        //    bool state = 
        //}
    }
}