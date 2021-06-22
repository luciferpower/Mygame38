using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Mygame38
{
    public partial class mygame : System.Web.UI.Page
    {
        public string s_ConnS = "Data Source=(localdb)\\ProjectsV13;" +
                     "Initial Catalog=Music1;" +
                     "Integrated Security=True;" +
                     "Connect Timeout=30;Encrypt=False;" +
                     "TrustServerCertificate=False;" +
                     "ApplicationIntent=ReadWrite;MultiSubnetFailover=False;" +
                     "User ID = sa ; Password = 12345";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection o_Conn = new SqlConnection(s_ConnS);
                o_Conn.Open();
                SqlCommand o_Com = new SqlCommand("Select * from Users", o_Conn);
                SqlDataReader o_R = o_Com.ExecuteReader();
                for (; o_R.Read();)
                {
                    for (int i_col = 0; i_col < o_R.FieldCount; i_col++)
                    {
                        Response.Write("&nbsp;&nbsp;" + o_R[i_col].ToString());
                    }
                    Response.Write("<br />");
                }
                o_Conn.Close();

            }
            catch (Exception o_Exc)
            {
                Response.Write(o_Exc.ToString());
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                Response.Redirect("https://www.youtube.com/watch?v=A2AwZZ4x0lA", false);
                HttpContext.Current.ApplicationInstance.CompleteRequest();
        }

        protected void Add_Name_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection o_Conn = new SqlConnection(s_ConnS);
                o_Conn.Open();
                SqlCommand o_Com = new SqlCommand("Insert into Users (Name,Url)" + "values(@Name, @Url)", o_Conn);          
                o_Com.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
                o_Com.Parameters["@Name"].Value = "佛系少女";
                o_Com.Parameters.Add("@Url", SqlDbType.NVarChar,-1);
                o_Com.Parameters["@Url"].Value = "https://www.youtube.com/watch?v=A2AwZZ4x0lA";
                o_Com.ExecuteNonQuery();
                o_Conn.Close();
                Response.Redirect("Mygame.aspx");
            }
            catch (Exception o_Exc)
            {
                Response.Write(o_Exc.ToString());
            }
        }

        protected void bn_del_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection o_Conn = new SqlConnection(s_ConnS);
                o_Conn.Open();
                SqlCommand o_Com = new SqlCommand("Delete from Users where Name = N'" + tb_Name.Text + "'", o_Conn);
                o_Com.ExecuteNonQuery();
                o_Conn.Close();
                Response.Redirect("Mygame.aspx");
            }
            catch (Exception o_Exc)
            {
                Response.Write(o_Exc.ToString());
            }
        }
    }
    
}