using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySqlConnector;

namespace PerfilUsuario
{
    public partial class perfil : System.Web.UI.Page
    {
        private MySqlConnection connection;

        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("Server=127.0.0.1;User ID=root;Password=;Database=devplus");

            connection.Open();
            var comando = new MySqlCommand($"SELECT `id`, `email`, `senha`, `nome` FROM `usuario_` WHERE email='caiqueandrada.85@gmail.com'", connection);
            var reader = comando.ExecuteReader();
            if (reader.Read())
            {
                txtNome.Text = reader.GetString("nome");
                txtEmail.Text = reader.GetString("email");
               

            }

            if (!IsPostBack)
            {
                recadsenha.Style.Value = "width: 600px;height: 440px;background-color:rgb(23, 23, 54);position: absolute;top: 330px;left: 500px;display: none;z-index: 2;border-radius: 4 % ";
                recad.Style.Value = "width: 600px;height: 350px;background-color:rgb(23, 23, 54);position: absolute;top: 329px;left: 500px; display:none;z-index: 2;border-radius: 4%;";

               

            }
            connection.Close();
        }

        protected void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            recadsenha.Style.Value = "width: 600px;height: 440px;background-color:rgb(23, 23, 54);position: absolute;top: 330px;left: 500px;display: block;z-index: 2;border-radius: 4 % ";
        }

        protected void btnAtualizarSenha_Click(object sender, EventArgs e)
        {

        }

        protected void btnAtualizarCadastro_Click(object sender, EventArgs e)
        {

        }


        protected void btnAle_Click(object sender, EventArgs e)
        {
            recad.Style.Value = "width: 600px;height: 350px;background-color:rgb(23, 23, 54);position: absolute;top: 329px;left: 500px; display:none;z-index: 2;border-radius: 4%;";
            recadsenha.Style.Value = "width: 600px;height: 440px;background-color:rgb(23, 23, 54);position: absolute;top: 330px;left: 500px;display: none;z-index: 2;border-radius: 4 % ";
        }

        protected void btnAlterar_Cadastro_Click(object sender, EventArgs e)
        {
            recad.Style.Value = "width: 600px;height: 350px;background-color:rgb(23, 23, 54);position: absolute;top: 329px;left: 500px; display:block;z-index: 2;border-radius: 4%;";

        }

    }
}