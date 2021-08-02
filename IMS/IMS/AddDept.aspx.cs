using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Data;

namespace IMS
{
    public partial class AddDept : System.Web.UI.Page
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
            String query = "INSERT INTO rl_dept_info (department_name) values('" + TextBox2.Text + "')";
            TextBox1.Text = "";
            TextBox2.Text = "";

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
            SqlCommand cmd = new SqlCommand("SELECT * FROM rl_dept_info", con);
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
            String query = "UPDATE rl_dept_info SET department_name='" + TextBox2.Text + "' WHERE id='" + int.Parse(TextBox1.Text) + "'";
            TextBox1.Text = "";
            TextBox2.Text = "";
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
            String query = "DELETE FROM rl_dept_info WHERE id='" + int.Parse(TextBox1.Text) + "'";
            TextBox1.Text = "";
            TextBox2.Text = "";
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM rl_dept_info WHERE id='" + int.Parse(TextBox1.Text) + "'", con);
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM rl_dept_info WHERE id='" + int.Parse(TextBox1.Text) + "'", con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                TextBox1.Text = r.GetValue(0).ToString();
                TextBox2.Text = r.GetValue(1).ToString();
            }
        }
    }
}