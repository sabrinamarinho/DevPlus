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
        public static string email;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(SiteMaster.ConnectionString);

            if (!IsPostBack)
            {
                if (Request.QueryString.Count > 0)
                {
                    string email = Request.QueryString["email"].ToString();




                    connection.Open();
                    Carousel.InnerHtml = "";


                    var comando = new MySqlCommand($"SELECT * FROM video_", connection);
                    var reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        Carousel.InnerHtml += $@" 
                <div class='carousel-cell' style='height: 600px; width:100%'>
                    <h1 class='text-center' style='color: white; z-index: 3;'>{reader.GetString("titulo")}</h1><br>
                    <a href = '../Tela de Exibição/Tela de Exibição.aspx?titulo={reader.GetString("titulo")} + ';email=' + {email}' ><img class='w3-image' style='height:600px; ' src='../Upload/videos/{reader.GetString("genero")}/{reader.GetString("titulo")}.jpg' /></a>
                   </div>";

                    }
                    connection.Close();
                }
                /*
                        protected void drop_genero_Click(object sender, EventArgs e)
                        {
                            connection.Open();
                            Carousel.InnerHtml = "";


                            var comando = new MySqlCommand($"SELECT * FROM video_", connection);
                            var reader = comando.ExecuteReader();
                            while (reader.Read())
                            {
                                Carousel.InnerHtml += $@" 
                                <div class='carousel - cell' style='height: 600px;'>
                                    <h1 class='text-center' style='color: white; z-index: 3;'>{reader.GetString("titulo")}</h1><br>
                                    <a href = '../Tela de Exibição/Tela de Exibição.aspx?titulo={reader.GetString("titulo")}' ><img class='w3-image' style='max - height:600px; ' src='../Upload/videos/{reader.GetString("genero")}/{reader.GetString("titulo")}.jpg' /></a>
                                   </div>";

                            }
                            connection.Close();
                        }
                        */
            }
        }
    }
}