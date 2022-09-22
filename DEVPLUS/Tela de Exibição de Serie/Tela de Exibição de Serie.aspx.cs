using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySqlConnector;

namespace DEVPLUS.Tela_de_Exibição_de_Serie
{
    public partial class Tela_de_Exibição_de_Serie : System.Web.UI.Page
    {
       public static string titulo;
        public static string genero;
      
        private MySqlConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {

            connection = new MySqlConnection(SiteMaster.ConnectionString);
            if (!IsPostBack)
            {
                if (Request.QueryString.Count > 0)
                {
                    titulo = Request.QueryString["titulo"].ToString();
                    connection.Open();
                    if (Request.QueryString["titulo"].ToString() == null)
                    {

                    }
                    else
                    {
                        var comando = new MySqlCommand($" SELECT `titulo`,`descricao`,genero FROM `serie_` WHERE `titulo`='{titulo}'", connection);
                        var reader = comando.ExecuteReader();
                        if (reader.Read())
                        {

                           



                            titulo_v.InnerText = reader.GetString("titulo");
                            descricao_v.InnerText = reader.GetString("descricao");
                            vidin.Src = $@"../Upload/serie/{reader.GetString("genero")}/{reader.GetString("titulo")}/Episódio 1.mp4";
                        }
                     genero = reader.GetString("genero");
                        titulo = reader.GetString("titulo");

                    }

                }

            }
        }
        protected void DropList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropList.SelectedValue =="1")
            {
                vidin.Src = $@"../Upload/serie/{genero}/{titulo}/Episódio 1.mp4";
               


          
            }
            if (DropList.SelectedValue == "2")
            {

                vidin.Src = $@"../Upload/serie/{genero}/{titulo}/Episódio 2.mp4";


            }
            if (DropList.SelectedValue == "3")
            {

                vidin.Src = $@"../Upload/serie/{genero}/{titulo}/Episódio 3.mp4";


            }
            if (DropList.SelectedValue == "4")
            {
                vidin.Src = $@"../Upload/serie/{genero}/{titulo}/Episódio 4.mp4";



            }
            if (DropList.SelectedValue == "5")
            {

                vidin.Src = $@"../Upload/serie/{genero}/{titulo}/Episódio 5.mp4";


            }
            if (DropList.SelectedValue == "6")
            {

                vidin.Src = $@"../Upload/serie/{genero}/{titulo}/Episódio 6.mp4";

           
            }
        }
    }
}