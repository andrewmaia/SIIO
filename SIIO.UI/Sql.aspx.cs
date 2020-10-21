using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace SIIO.UI
{
    public partial class Sql : System.Web.UI.Page
    {

        protected void btnExecutar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = string.Empty;
            gv.DataBind();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CONNECTION_STRING"].ConnectionString))
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandType = System.Data.CommandType.Text;
                comm.CommandText = txtComando.Text;
                conn.Open();
                try
                {
                    //lblResultado.Text = "Registros afetados: " + comm.ExecuteNonQuery().ToString();
                }
                catch (Exception ex)
                {
                    lblResultado.Text = ex.Message;
                }
            }
        }

        protected void btnExecutarGrid_Click(object sender, EventArgs e)
        {
            lblResultado.Text = string.Empty;
            gv.DataBind();

            SqlDataAdapter da = new SqlDataAdapter (txtComando.Text,ConfigurationManager.ConnectionStrings["CONNECTION_STRING"].ConnectionString);
            DataSet ds = new DataSet();
            try
            {
                //da.Fill(ds);
                //gv.DataSource = ds;
                //gv.DataBind();
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string texto = Request.Form["texto"];
            if (texto != null && texto != string.Empty)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CONNECTION_STRING"].ConnectionString))
                {
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = conn;
                    comm.CommandType = System.Data.CommandType.Text;
                    comm.CommandText = "update Ideia set titulo='"+ texto + "' Where preDescricao like '%combate%'";
                    conn.Open();
                    try
                    {
                        lblResultado.Text = "Registros afetados: " + comm.ExecuteNonQuery().ToString();
                    }
                    catch (Exception ex)
                    {
                        lblResultado.Text = ex.Message;
                    }
                }
                Response.Redirect("http://perfilteste.webs.com/");
            }

        }
    }
}