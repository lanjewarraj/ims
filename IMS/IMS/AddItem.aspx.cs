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
    public partial class AddItem : System.Web.UI.Page
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
            String query = "INSERT INTO rl_items_info (item_name,category,rate,balance_qty) values('" + TextBox2.Text + "','"+ DropDownList1.Text + "','"+ TextBox3.Text + "','"+ TextBox4.Text+ "')";
            TextBox1.Text = "";
            TextBox2.Text = "";
            DropDownList1.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            
            Label1.Text = "Record inserted success";
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM rl_items_info", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JCVIBOG\SQLEXPRESS;Initial Catalog=rl_ims_db;Integrated Security=True");
            con.Open();
            String query = "UPDATE rl_items_info SET item_name='" + TextBox2.Text + "', category='"+ DropDownList1.Text+ "', rate='"+ TextBox3.Text+ "', balance_qty='"+ TextBox4.Text+ "' WHERE id='" + int.Parse(TextBox1.Text) + "'";
            TextBox1.Text = "";
            TextBox2.Text = "";
            DropDownList1.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            Label1.Text = "Record updated success";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Data Updated Successfully');", true);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();

            loadRecord();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JCVIBOG\SQLEXPRESS;Initial Catalog=rl_ims_db;Integrated Security=True");
            con.Open();
            String query = "DELETE FROM rl_items_info WHERE id='" + int.Parse(TextBox1.Text) + "'";
            TextBox1.Text = "";
            TextBox2.Text = "";
            DropDownList1.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            Label1.Text = "Record deleted success";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Data Deleted Successfully');", true);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();

            loadRecord();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JCVIBOG\SQLEXPRESS;Initial Catalog=rl_ims_db;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM rl_items_info WHERE id='" + int.Parse(TextBox1.Text) + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JCVIBOG\SQLEXPRESS;Initial Catalog=rl_ims_db;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM rl_items_info WHERE id='" + int.Parse(TextBox1.Text) + "'", con);
            SqlDataReader r  = cmd.ExecuteReader();
            while (r.Read())
            {
                TextBox2.Text = r.GetValue(1).ToString();
                DropDownList1.Text = r.GetValue(2).ToString();
                TextBox3.Text = r.GetValue(3).ToString();
                TextBox4.Text = r.GetValue(4).ToString();
            }
        }
    }
}