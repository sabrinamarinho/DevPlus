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
                <div class='carousel - cell' style='height: 600px;'>
                    <h1 class='text-center' style='color: white; z-index: 3;'>{reader.GetString("titulo")}</h1><br>
                    <a href = '../Tela de Exibição/Tela de Exibição.aspx?titulo={reader.GetString("titulo")}.mp4' ><img class='w3-image' src='@'C: \Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front - end\'{reader.GetString("titulo")}.jpg' /></a>
                   </div>";
               
            }
            connection.Close();
        }

       
    }
}