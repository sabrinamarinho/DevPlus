using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySqlConnector;

namespace DEVPLUS.LOGIN
{
    public partial class Login : System.Web.UI.Page
    {
        public static string ConnectionString = "Server=127.0.0.1;User ID=root;Password=;Database=devplus";
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

        protected void btngo_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);

            connection.Open();


            var comando = new MySqlCommand($"SELECT * FROM usuario_ WHERE (email = @email OR nome = @email) AND  senha = MD5(@senha)", connection);
            comando.Parameters.Add(new MySqlParameter("email", txtemail.Text));
            comando.Parameters.Add(new MySqlParameter("senha", txtpassword.Text));
            var reader = comando.ExecuteReader();
            if (reader.Read())
            {
                Response.Redirect("../Tela Interna/Tela Interna.aspx");

            }
            else
            {
                valida.InnerText = "Email ou senha incorreta !";
            }

            connection.Close();
        }
    }
}