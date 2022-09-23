using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySqlConnector;

namespace DEVPLUS.CATEGORIAS.Automacao
{
    public partial class Automacao : System.Web.UI.Page
    {
        private MySqlConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(SiteMaster.ConnectionString);

            connection.Open();



            var comando = new MySqlCommand($"SELECT * FROM `video_` WHERE `genero`='automacao'", connection);
            var reader = comando.ExecuteReader();
            int contador = 0;

            while (reader.Read())
            {
                contador++;
                if (contador == 1)
                {
                    lista_videos.InnerHtml += $@"                   
                    <div class=""item active"">
                    <div class=""row"">";
                }
                if (contador % 5 == 0)
                {
                    lista_videos.InnerHtml += $@"
                      </div>
                      </div>";
                    lista_videos.InnerHtml += $@"                   
                    <div class=""item"">
                    <div class=""row"">";
                }
                lista_videos.InnerHtml += $@"
                         <div class=""col-sm-3"">
							<div class=""thumb-wrapper"">
								<span class=""wish-icon""><i class=""fa fa-heart-o""></i></span>
								<div class=""img-box"">
									<img src=""../../Upload/videos/{reader.GetString("genero")}/{reader.GetString("titulo")}.jpg"" class=""img-responsive"" alt="""">									
								</div>
								<div class=""thumb-content"">
									<h4 >{reader.GetString("titulo")}</h4>	
									<a href = ""../../Tela de Exibição/Tela de Exibição.aspx?titulo={reader.GetString("titulo")}"" class=""btn btn-primary"">ASSISTIR</a>
								</div>						
							</div>
						</div>";


            }

            lista_videos.InnerHtml += $@"
                      </div>
                      </div>";


            connection.Close();



            connection.Open();


            Carousel.InnerHtml = "";
            var command1 = new MySqlCommand($"SELECT * FROM `serie_` WHERE `genero`='automacao'", connection);
            var leitor = command1.ExecuteReader();
            while (leitor.Read())
            {
                Carousel.InnerHtml += $@" 
                <div class='carousel-cell' style='height: 600px;width:100% '>
                    <h1 class='text-center' style='color: white; z-index: 3;'>{leitor.GetString("titulo")}</h1><br>
                    <a href = '../../Tela de Exibição/Tela de Exibição.aspx?titulo={leitor.GetString("titulo")}' ><img class='w3-image' style='height:600px; ' src='../../Upload/serie/{leitor.GetString("genero")}/{leitor.GetString("titulo")}/{leitor.GetString("titulo")}.jpg' /></a>
                   </div>";

            }


            connection.Close();

        }

        protected void txtbusca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}