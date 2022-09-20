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
                        var comando = new MySqlCommand($" SELECT `titulo`,`descriçao`,genero FROM `video_` WHERE `titulo`='{titulo}'", connection);
                        var reader = comando.ExecuteReader();
                        if (reader.Read())
                        {
                            titulo_v.InnerText = reader.GetString("titulo");
                            descricao_v.InnerText = reader.GetString("descriçao");
                            vidin.Src = $@"../Upload/videos/{reader.GetString("genero")}/{reader.GetString("titulo")}.mp4";
                        }

                    }
                }
            }
        }
    }
}