using FinalQuiz.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalQuiz
{
    public partial class Transaction : System.Web.UI.Page
    {
        //static Database db = new Database();
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    //accessible for admin and member
        //    if(Session["Role"].Equals("Member"))
        //    {
        //        Transaction.Visible = true; //
        //    }
        //    else if (Session["Role"].Equals("Admin"))
        //    {
        //        //
        //        GenTransRepBtn.Visible = true;
        //    }
        //}

        //void getAllData()
        //{
        //    cartGridView.DataSource = ProductRepository.getAll();
        //}

        //protected void GenerateReportBtn_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TransactionReport.aspx");
        //}
    }
}