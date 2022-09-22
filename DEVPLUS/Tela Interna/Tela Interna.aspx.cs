using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySqlConnector;

namespace DEVPLUS.Tela_Interna
{
    
    public partial class Tela_Interna : System.Web.UI.Page
    {
        private MySqlConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {

            connection = new MySqlConnection(SiteMaster.ConnectionString);

            connection.Open();
            Carousel.InnerHtml = "";

            
            var comando = new MySqlCommand($"SELECT * FROM video_", connection);
            var reader = comando.ExecuteReader();
            while(reader.Read())
            {
                Carousel.InnerHtml += $@" 
                <div class='carousel-cell' style='height: 600px; width:100%'>
                    <h1 class='text-center' style='color: white; z-index: 3;'>{reader.GetString("titulo")}</h1><br>
                    <a href = '../Tela de Exibição/Tela de Exibição.aspx?titulo={reader.GetString("titulo")}' ><img class='w3-image' style='height:600px; ' src='../Upload/videos/{reader.GetString("genero")}/{reader.GetString("titulo")}.jpg' /></a>
                   </div>";
                
            }

            connection.Close();

            /*
            connection.Open();
            if(btn_busca == null)
            {

            }
            else
            {
                Carousel.InnerHtml = "";


                var comand = new MySqlCommand($"SELECT * FROM video_ AND serie_ WHERE titulo LIKE '%%'", connection);
                var reader1 = comand.ExecuteReader();
                while (reader1.Read())
                {
                    Carousel.InnerHtml += $@" 
                <div class='carousel-cell' style='height: 600px; width:100%'>
                    <h1 class='text-center' style='color: white; z-index: 3;'>{reader.GetString("titulo")}</h1><br>
                    <a href = '../Tela de Exibição/Tela de Exibição.aspx?titulo={reader.GetString("titulo")}' ><img class='w3-image' style='height:600px; ' src='../Upload/videos/{reader.GetString("genero")}/{reader.GetString("titulo")}.jpg' /></a>
                   </div>";

                }
            }

            connection.Close();
            */

        }

        protected void btn_buscar_Click1(object sender, ImageClickEventArgs e)
        {
           
        }

        protected void txtbusca_TextChanged(object sender, EventArgs e)
        {
            connection.Open();


            Carousel.InnerHtml = "";


            var comand = new MySqlCommand($"SELECT * FROM video_ WHERE titulo LIKE '%{txtbusca.Text}%'", connection);
            var reader1 = comand.ExecuteReader();
            while (reader1.Read())
            {
                Carousel.InnerHtml += $@" 
                <div class='carousel-cell' style='height: 600px; width:100%'>
                    <h1 class='text-center' style='color: white; z-index: 3;'>{reader1.GetString("titulo")}</h1><br>
                    <a href = '../Tela de Exibição/Tela de Exibição.aspx?titulo={reader1.GetString("titulo")}' ><img class='w3-image' style='height:600px; ' src='../Upload/videos/{reader1.GetString("genero")}/{reader1.GetString("titulo")}.jpg' /></a>
                   </div>";

            }

            connection.Close();
        }
    }
}