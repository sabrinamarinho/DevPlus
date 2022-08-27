using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySqlConnector;

namespace DevPlus
{
    public partial class Cadastrar : System.Web.UI.Page
    {
        private MySqlConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cadastro_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(SiteMaster.ConnectionString);

            connection.Open();

            if(teste_senha.Text == teste_senha2.Text)
            {
                var commando = new MySqlCommand($"INSERT INTO usuario_ (email,senha,nome) VALUES (@email,MD5(@senha),@nome)", connection);
                commando.Parameters.Add(new MySqlParameter("email", teste_email.Text));
                commando.Parameters.Add(new MySqlParameter("senha", teste_senha.Text));
                commando.Parameters.Add(new MySqlParameter("nome", nome_texte.Text));
                commando.ExecuteNonQuery();
                SiteMaster.ExibirAlert(this, "cadastrado");
            }
            else
            {
                SiteMaster.ExibirAlert(this, "senha diferentes");
            }

            connection.Close();

        }
    }
}