using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySqlConnector;
namespace DEVPLUS.Perfil
{
    public partial class Perfil : System.Web.UI.Page
    {
        private MySqlConnection connection;
        public static string email;
        public static string nome;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("Server=127.0.0.1;User ID=root;Password=;Database=devplus");
            if (!IsPostBack)
            {
                email = Request.QueryString["email"].ToString();


                connection.Open();
                var comando = new MySqlCommand($"SELECT `id`, `email`, `senha`, @nome FROM `usuario_` WHERE email='{email}'", connection);
                var reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    txtNome.Text = ToString("nome");
                    txtEmail.Text = email;


                }


                recadsenha.Style.Value = "width: 600px;height: 440px;background-color:rgb(23, 23, 54);position: absolute;top: 330px;left: 500px;display: none;z-index: 2;border-radius: 4 % ";
                recad.Style.Value = "width: 600px;height: 350px;background-color:rgb(23, 23, 54);position: absolute;top: 329px;left: 500px; display:none;z-index: 2;border-radius: 4%;";


                connection.Close();

                if (Request.QueryString.Count > 0)
                {

                }

            }
        }

        protected void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            recadsenha.Style.Value = "width: 600px;height: 440px;background-color:rgb(23, 23, 54);position: absolute;top: 330px;left: 500px;display: block;z-index: 2;border-radius: 4 % ";
        }

        protected void btnAlterar_Cadastro_Click(object sender, EventArgs e)
        {
            recad.Style.Value = "width: 600px;height: 350px;background-color:rgb(23, 23, 54);position: absolute;top: 329px;left: 500px; display:block;z-index: 2;border-radius: 4%;";
        }

        protected void btnAle_Click(object sender, EventArgs e)
        {
            recad.Style.Value = "width: 600px;height: 350px;background-color:rgb(23, 23, 54);position: absolute;top: 329px;left: 500px; display:none;z-index: 2;border-radius: 4%;";
            recadsenha.Style.Value = "width: 600px;height: 440px;background-color:rgb(23, 23, 54);position: absolute;top: 330px;left: 500px;display: none;z-index: 2;border-radius: 4 % ";
        }

        protected void btnAtualizarCadastro_Click(object sender, EventArgs e)
        {
            var comand = new MySqlCommand($"UPDATE `usuario_` SET nome = @nome,email = @email WHERE id = @id", connection);
            comand.Parameters.Add(new MySqlParameter("nome", txtAlteraNomeUsuario));
            comand.Parameters.Add(new MySqlParameter("email", txtAlteraEmailUsuario));
            comand.ExecuteNonQuery();
        }

        protected void btnAtualizarSenha_Click(object sender, EventArgs e)
        {
            connection.Open();

            if (txtNovaSenha == txtConfirmarSenha)
            {
                var comand = new MySqlCommand($"UPDATE `usuario_` SET senha = MD5(@senha) WHERE id = @id", connection);
                comand.Parameters.Add(new MySqlParameter("senha", txtNovaSenha));
                comand.ExecuteNonQuery();

            }
            connection.Close();
        }
    }
}