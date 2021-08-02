using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace IMS
{
    public partial class AddVendor : System.Web.UI.Page
    { 

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadRecord();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JCVIBOG\SQLEXPRESS;Initial Catalog=rl_ims_db;Integrated Security=True");
            con.Open();
            String query = "INSERT INTO rl_vendor_info (vendor_name) values('"+ TextBox1.Text + "')";
            TextBox1.Text = "";
            showmsg.Text = "Record inserted success";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Data Inserted Successfull');", true);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();

            //call record load method from database
            loadRecord();
        }
        void loadRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JCVIBOG\SQLEXPRESS;Initial Catalog=rl_ims_db;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM rl_vendor_info",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}