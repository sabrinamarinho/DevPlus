using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySqlConnector;

namespace DevPlus
{
    public partial class Login : System.Web.UI.Page
    {
        private MySqlConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(SiteMaster.ConnectionString);

            connection.Open();

            
            var comando = new MySqlCommand($"SELECT * FROM usuario_ WHERE (email = @email OR nome = @email) AND  senha = MD5(@senha)", connection);
            comando.Parameters.Add(new MySqlParameter("email", email.Text));
            comando.Parameters.Add(new MySqlParameter("senha", senha.Text));
            var reader = comando.ExecuteReader();
            if(reader.Read())
            {
                SiteMaster.ExibirAlert(this, "logado");
            }
            else
            {
                SiteMaster.ExibirAlert(this, "usuario ou senha invalidos!");

            }

            connection.Close();

        }
    }
}