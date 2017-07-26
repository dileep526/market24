using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace market24
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source= venus\\dev2012;database = Training ; Integrated Security= SSPI");
            con.Open();
            SqlCommand scom = new SqlCommand("INSERT INTO products(item,quantity,price) values(@kname,@ksurname,@knam)", con);
            //  SqlCommand cmd = new SqlCommand("select * from login", con);

          //  Response.Write("Now Please login With your Credentials and Write Exam");


            scom.Parameters.AddWithValue("@kname", Label1.Text);
            scom.Parameters.AddWithValue("@ksurname", DropDownList1.Text);
            scom.Parameters.AddWithValue("@knam", Label5.Text);


            scom.ExecuteNonQuery();


            con.Close();
            Response.Redirect("bill.aspx");
        }
    }
}