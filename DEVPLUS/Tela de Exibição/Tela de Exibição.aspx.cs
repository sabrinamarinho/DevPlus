using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySqlConnector;

namespace DEVPLUS.Tela_de_Exibição
{
    public partial class Tela_de_Exibição : System.Web.UI.Page
    {
        private MySqlConnection connection;
        public static int id;
        public static string email;
        public static int id_usu;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(SiteMaster.ConnectionString);

            connection.Open();
            if (!IsPostBack)
            {
                if (Request.QueryString.Count > 0)
                {
                    string titulo = Request.QueryString["titulo"].ToString();

                    if (Request.QueryString["titulo"].ToString() == null)
                    {

                    }
                    else
                    {
                        var comando = new MySqlCommand($" SELECT `titulo`,`descriçao`,genero,id FROM `video_` WHERE `titulo`='{titulo}'", connection);
                        var reader = comando.ExecuteReader();
                        if (reader.Read())
                        {
                            titulo_v.InnerText = reader.GetString("titulo");
                            descricao_v.InnerText = reader.GetString("descriçao");
                            vidin.Src = $@"../Upload/videos/{reader.GetString("genero")}/{reader.GetString("titulo")}.mp4";

                            id = reader.GetInt32("id");
                        }
                    }
                }
                connection.Close();
              

              
             }
               

           
           
        }
        
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            connection.Open();

            var commando = new MySqlCommand($"INSERT INTO `lista_`(`id`, `id_usuario`, `id_video`) VALUES (NULL,@id_usuario,@id_video)", connection);
            commando.Parameters.Add(new MySqlParameter("id_usuario",id_usu));
            commando.Parameters.Add(new MySqlParameter("id_video", id));
            commando.ExecuteNonQuery();
            connection.Close();
        }

        protected void Unnamed_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("../Tela Interna/Tela Interna.aspx?email=" + email);
        }
    }
}