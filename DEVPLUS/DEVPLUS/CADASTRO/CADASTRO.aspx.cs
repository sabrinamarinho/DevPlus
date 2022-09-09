using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySqlConnector;


namespace DEVPLUS.CADASTRO
{
    public partial class CADASTRO : System.Web.UI.Page
    {
        private MySqlConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString.Count > 0)
                {
                    string email = Request.QueryString["email"].ToString();
                    if (Request.QueryString["email"].ToString() == null)
                    {
                        txtemail.Text = "";
                    }
                    else
                    {
                        txtemail.Text = email;
                    }
                }
            }

        }

        protected void cadastrarbtn_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(SiteMaster.ConnectionString);

            connection.Open();

            if (password.Text == Cpassword.Text)
            {
                var commando = new MySqlCommand($"INSERT INTO usuario_ (email,senha,nome) VALUES (@email,MD5(@senha),@nome)", connection);
                commando.Parameters.Add(new MySqlParameter("email", txtemail.Text));
                commando.Parameters.Add(new MySqlParameter("senha", password.Text));
                commando.Parameters.Add(new MySqlParameter("nome", txtnome.Text));
                commando.ExecuteNonQuery();
               
            }
         
   
            connection.Close();
            Response.Redirect("/LOGIN/Login.aspx?email=" + txtemail.Text);
        }
    }
}