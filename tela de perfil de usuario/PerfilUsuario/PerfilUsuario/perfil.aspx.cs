using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PerfilUsuario
{
    public partial class perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                recadsenha.Style.Value = "width: 600px;height: 440px;background-color:rgb(23, 23, 54);position: absolute;top: 330px;left: 500px;display: none;z-index: 2;border-radius: 4 % ";
                recad.Style.Value = "width: 600px;height: 350px;background-color:rgb(23, 23, 54);position: absolute;top: 329px;left: 500px; display:none;z-index: 2;border-radius: 4%;";
            }
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