using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySqlConnector;
namespace DEVPLUS.Upload
{
    public partial class Upload : System.Web.UI.Page
    {
        private MySqlConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(listTip.Value== "Vídeo")
            {
                serie.Style.Value = "display:none";
                serieend.Style.Value = "display:none";
                video.Style.Value = "display:none";

            }
            else
            {
                serie.Style.Value = "display:none";
                serieend.Style.Value = "display:none";
                video.Style.Value = "display:none";

            }

        }


        protected void BtnUpload_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(SiteMaster.ConnectionString);

            //---------------------------------------------------------------------------Video-----------------------------------------------------------------------------------------


            if (FileUpLoad1.HasFile && listGen.Value== "Front-End")
            {
                connection.Open();

                var commando = new MySqlCommand($"INSERT INTO video_ (titulo,genero,descriçao,id_admin) VALUES (@titulo,genero = 'FrontEnd',@descriçao,id_admin = '0')", connection);
                commando.Parameters.Add(new MySqlParameter("titulo", txtTitulo.Value));
                commando.Parameters.Add(new MySqlParameter("descriçao", txtDesc.Value));
                commando.ExecuteNonQuery();

                if (FileUpLoad1.HasFile)
                {
                    FileUpLoad1.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + FileUpLoad1.FileName);
                    string oldname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + FileUpLoad1.FileName;
                    string newname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + txtTitulo.Value + ".mp4";

                    System.IO.File.Move(oldname, newname);
                }


                if (FileUpload2.HasFile)
                {
                    FileUpload2.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + FileUpload2.FileName);
                    string cname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + FileUpload2.FileName;
                    string ciname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + txtTitulo.Value + ".jpg";

                    System.IO.File.Move(cname, ciname);
                }

                



                connection.Close();
            }
           
            if (FileUpLoad1.HasFile && listGen.Value == "Back-End")
            {
                connection.Open();
                var commando = new MySqlCommand($"INSERT INTO video_ (titulo,genero,descriçao,id_admin) VALUES (@titulo,genero = 'BackEnd',@descriçao,id_admin = '0')", connection);
                commando.Parameters.Add(new MySqlParameter("titulo", txtTitulo.Value));
                commando.Parameters.Add(new MySqlParameter("descriçao", txtDesc.Value));
                commando.ExecuteNonQuery();

                if (FileUpLoad1.HasFile)
                {
                    FileUpLoad1.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + FileUpLoad1.FileName);
                    string oldname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + FileUpLoad1.FileName;
                    string newname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + txtTitulo.Value + ".mp4";

                    System.IO.File.Move(oldname, newname);
                }


                if (FileUpload2.HasFile)
                {
                    FileUpload2.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + FileUpload2.FileName);
                    string cname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + FileUpload2.FileName;
                    string ciname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + txtTitulo.Value + ".jpg";

                    System.IO.File.Move(cname, ciname);
                }

            }
           
            if (FileUpLoad1.HasFile && listGen.Value == "Automação Python")
            {

                connection.Open();

                var commando = new MySqlCommand($"INSERT INTO video_ (titulo,genero,descriçao,id_admin) VALUES (@titulo,genero = 'Automaçao Python',@descriçao,id_admin = '0')", connection);
                commando.Parameters.Add(new MySqlParameter("titulo", txtTitulo.Value));
                commando.Parameters.Add(new MySqlParameter("descriçao", txtDesc.Value));
                commando.ExecuteNonQuery();

                if (FileUpLoad1.HasFile)
                {
                    FileUpLoad1.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + FileUpLoad1.FileName);
                    string oldname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + FileUpLoad1.FileName;
                    string newname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + txtTitulo.Value + ".mp4";

                    System.IO.File.Move(oldname, newname);
                }


                if (FileUpload2.HasFile)
                {
                    FileUpload2.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + FileUpload2.FileName);
                    string cname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + FileUpload2.FileName;
                    string ciname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + txtTitulo.Value + ".jpg";

                    System.IO.File.Move(cname, ciname);
                }

                connection.Close();

            }
          
            if (FileUpLoad1.HasFile && listGen.Value == "Banco De Dados")
            {

                connection.Open();

                var commando = new MySqlCommand($"INSERT INTO video_ (titulo,genero,descriçao,id_admin) VALUES (@titulo,genero = 'Banco De Dados',@descriçao,id_admin = '0')", connection);
                commando.Parameters.Add(new MySqlParameter("titulo", txtTitulo.Value));
                commando.Parameters.Add(new MySqlParameter("descriçao", txtDesc.Value));
                commando.ExecuteNonQuery();

                if (FileUpLoad1.HasFile)
                {
                    FileUpLoad1.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + FileUpLoad1.FileName);
                    string oldname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + FileUpLoad1.FileName;
                    string newname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + txtTitulo.Value + ".mp4";

                    System.IO.File.Move(oldname, newname);
                }


                if (FileUpload2.HasFile)
                {
                    FileUpload2.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + FileUpload2.FileName);
                    string cname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + FileUpload2.FileName;
                    string ciname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + txtTitulo.Value + ".jpg";

                    System.IO.File.Move(cname, ciname);
                }

                connection.Close();

            }
            else
            {

            }
            
        }

        //-------------------------------------------------------------------------Serie-------------------------------------------------------------------------------------------

        protected void Ok_Click(object sender, EventArgs e)
        {
            if (listTip.Value == "Vídeo")
            {
                serie.Style.Value = "display:none";
                serieend.Style.Value = "display:none";
                video.Style.Value = "display:block;";

            }
            else
            {
                serie.Style.Value = "display:block;background-color: rgba(36, 36, 36); border-radius: 20px; margin-top:-530px;";
                
                video.Style.Value = "display:none";

            }

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            serie.Style.Value = "display:none";
        }

        protected void UpSerie_Click(object sender, EventArgs e)
        {

            connection = new MySqlConnection(SiteMaster.ConnectionString);


            if (listGen.Value == "Back-End")
            {

                connection.Open();
                var commando = new MySqlCommand($"INSERT INTO serie_ (titulo,genero,descriçao,id_video) VALUES (@titulo,genero = 'BackEnd',@descriçao,id_video)", connection);
                commando.Parameters.Add(new MySqlParameter("titulo", txtTitulo.Value));
                commando.Parameters.Add(new MySqlParameter("descriçao", txtDesc.Value));
                commando.ExecuteNonQuery();

                string folder = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\back-end\" + txtTitulo.Value; //nome do diretorio a ser criado

                //Se o diretório não existir...

                if (!Directory.Exists(folder))
                {

                    //Criamos um com o nome folder
                    Directory.CreateDirectory(folder);

                }

                if (FileEp1.HasFile)
                {
                    FileEp1.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\back-end\" + txtTitulo.Value + @"\" + FileEp1.FileName);


                    string oldname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\back-end\" + txtTitulo.Value + @"\" + FileEp1.FileName;
                    string newname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\back-end\" + txtTitulo.Value + @"\" + "Episódio 1" + ".mp4";
                    System.IO.File.Move(oldname, newname);
                }
                else
                {

                }

                if (FileEp2.HasFile)
                {
                    FileEp2.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\back-end\" + txtTitulo.Value + @"\" + FileEp2.FileName);


                    string antname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\back-end\" + txtTitulo.Value + @"\" + FileEp2.FileName;
                    string novname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\back-end\" + txtTitulo.Value + @"\" + "Episódio 2" + ".mp4";
                    System.IO.File.Move(antname, novname);
                }
                else
                {

                }

                if (FileEp3.HasFile)
                {
                    FileEp3.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\back-end\" + txtTitulo.Value + @"\" + FileEp3.FileName);


                    string aname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\back-end\" + txtTitulo.Value + @"\" + FileEp3.FileName;
                    string nname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\back-end\" + txtTitulo.Value + @"\" + "Episódio 3" + ".mp4";
                    System.IO.File.Move(aname, nname);
                }
                else
                {

                }

                if (FileEp4.HasFile)
                {
                    FileEp4.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\back-end\" + txtTitulo.Value + @"\" + FileEp4.FileName);


                    string anname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\back-end\" + txtTitulo.Value + @"\" + FileEp4.FileName;
                    string noname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\back-end\" + txtTitulo.Value + @"\" + "Episódio 4" + ".mp4";
                    System.IO.File.Move(anname, noname);
                }
                else
                {

                }

                if (FileEp5.HasFile)
                {
                    FileEp5.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\back-end\" + txtTitulo.Value + @"\" + FileEp5.FileName);


                    string bname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\back-end\" + txtTitulo.Value + @"\" + FileEp5.FileName;
                    string boname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\back-end\" + txtTitulo.Value + @"\" + "Episódio 5" + ".mp4";
                    System.IO.File.Move(bname, boname);
                }
                else { }

                if (FileImg.HasFile)
                {
                    FileImg.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\back-end\" + txtTitulo.Value + @"\" + FileImg.FileName);
                    string cname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\back-end\" + txtTitulo.Value + @"\" + FileImg.FileName;
                    string ciname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\back-end\" + txtTitulo.Value + @"\" + txtTitulo.Value + ".jpg";
                    System.IO.File.Move(cname, ciname);
                }
                else
                {

                }

                connection.Close();
            }

            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------
            if (listGen.Value == "Front-End")
            {
                connection.Open();

                var commando = new MySqlCommand($"INSERT INTO video_ (titulo,genero,descriçao) VALUES (@titulo,genero = 'FrontEnd',@descriçao)", connection);
                commando.Parameters.Add(new MySqlParameter("titulo", txtTitulo.Value));
                commando.Parameters.Add(new MySqlParameter("descriçao", txtDesc.Value));
                commando.ExecuteNonQuery();

                string folder = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\front-end\" + txtTitulo.Value; //nome do diretorio a ser criado

                //Se o diretório não existir...

                if (!Directory.Exists(folder))
                {

                    //Criamos um com o nome folder
                    Directory.CreateDirectory(folder);

                }

                if (FileEp1.HasFile)
                {
                    FileEp1.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\front-end\" + txtTitulo.Value + @"\" + FileEp1.FileName);


                    string oldname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\front-end\" + txtTitulo.Value + @"\" + FileEp1.FileName;
                    string newname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\front-end\" + txtTitulo.Value + @"\" + "Episódio 1" + ".mp4";
                    System.IO.File.Move(oldname, newname);
                }
                else
                {

                }

                if (FileEp2.HasFile)
                {
                    FileEp2.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\front-end\" + txtTitulo.Value + @"\" + FileEp2.FileName);


                    string antname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\front-end\" + txtTitulo.Value + @"\" + FileEp2.FileName;
                    string novname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\front-end\" + txtTitulo.Value + @"\" + "Episódio 2" + ".mp4";
                    System.IO.File.Move(antname, novname);
                }
                else
                {

                }

                if (FileEp3.HasFile)
                {
                    FileEp3.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\front-end\" + txtTitulo.Value + @"\" + FileEp3.FileName);


                    string aname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\front-end\" + txtTitulo.Value + @"\" + FileEp3.FileName;
                    string nname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\front-end\" + txtTitulo.Value + @"\" + "Episódio 3" + ".mp4";
                    System.IO.File.Move(aname, nname);
                }
                else
                {

                }

                if (FileEp4.HasFile)
                {
                    FileEp4.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\front-end\" + txtTitulo.Value + @"\" + FileEp4.FileName);


                    string anname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\front-end\" + txtTitulo.Value + @"\" + FileEp4.FileName;
                    string noname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\front-end\" + txtTitulo.Value + @"\" + "Episódio 4" + ".mp4";
                    System.IO.File.Move(anname, noname);
                }
                else
                {

                }

                if (FileEp5.HasFile)
                {
                    FileEp5.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\front-end\" + txtTitulo.Value + @"\" + FileEp5.FileName);


                    string bname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\front-end\" + txtTitulo.Value + @"\" + FileEp5.FileName;
                    string boname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\front-end\" + txtTitulo.Value + @"\" + "Episódio 5" + ".mp4";
                    System.IO.File.Move(bname, boname);
                }
                else { }

                if (FileImg.HasFile)
                {
                    FileImg.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\front-end\" + txtTitulo.Value + @"\" + FileImg.FileName);
                    string cname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\front-end\" + txtTitulo.Value + @"\" + FileImg.FileName;
                    string ciname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\front-end\" + txtTitulo.Value + @"\" + txtTitulo.Value + ".jpg";
                    System.IO.File.Move(cname, ciname);
                }
                else
                {

                }
                connection.Close();
            }
            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------
            if ( listGen.Value == "Automação Python")
            {

                connection.Open();

                var commando = new MySqlCommand($"INSERT INTO video_ (titulo,genero,descriçao,id_video) VALUES (@titulo,genero = 'Automaçao Python',@descriçao,id_video)", connection);
                commando.Parameters.Add(new MySqlParameter("titulo", txtTitulo.Value));
                commando.Parameters.Add(new MySqlParameter("descriçao", txtDesc.Value));
                commando.ExecuteNonQuery();

                string folder = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\automacao\" + txtTitulo.Value; //nome do diretorio a ser criado

                //Se o diretório não existir...

                if (!Directory.Exists(folder))
                {

                    //Criamos um com o nome folder
                    Directory.CreateDirectory(folder);

                }

                if(FileEp1.HasFile){
                    FileEp1.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\automacao\" + txtTitulo.Value + @"\" + FileEp1.FileName);


                    string oldname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\automacao\" + txtTitulo.Value + @"\" + FileEp1.FileName;
                    string newname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\automacao\" + txtTitulo.Value + @"\" + "Episódio 1" + ".mp4";
                    System.IO.File.Move(oldname, newname);
                }
                else
                {

                }

                if (FileEp2.HasFile)
                {
                    FileEp2.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\automacao\" + txtTitulo.Value + @"\" + FileEp2.FileName);


                    string antname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\automacao\" + txtTitulo.Value + @"\" + FileEp2.FileName;
                    string novname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\automacao\" + txtTitulo.Value + @"\" + "Episódio 2" + ".mp4";
                    System.IO.File.Move(antname, novname);
                }
                else
                {

                }

                if(FileEp3.HasFile) {
                    FileEp3.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\automacao\" + txtTitulo.Value + @"\" + FileEp3.FileName);


                    string aname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\automacao\" + txtTitulo.Value + @"\" + FileEp3.FileName;
                    string nname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\automacao\" + txtTitulo.Value + @"\" + "Episódio 3" + ".mp4";
                    System.IO.File.Move(aname, nname);
                }
                else
                {

                }

                if (FileEp4.HasFile) {
                    FileEp4.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\automacao\" + txtTitulo.Value + @"\" + FileEp4.FileName);


                    string anname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\automacao\" + txtTitulo.Value + @"\" + FileEp4.FileName;
                    string noname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\automacao\" + txtTitulo.Value + @"\" + "Episódio 4" + ".mp4";
                    System.IO.File.Move(anname, noname);
                }
                else
                {

                }

                if (FileEp5.HasFile) {
                    FileEp5.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\automacao\" + txtTitulo.Value + @"\" + FileEp5.FileName);


                    string bname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\automacao\" + txtTitulo.Value + @"\" + FileEp5.FileName;
                    string boname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\automacao\" + txtTitulo.Value + @"\" + "Episódio 5" + ".mp4";
                    System.IO.File.Move(bname, boname);
                }
                else { }

                if (FileImg.HasFile) {
                    FileImg.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\automacao\" + txtTitulo.Value + @"\" + FileImg.FileName);
                    string cname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\automacao\" + txtTitulo.Value + @"\" + FileImg.FileName;
                    string ciname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\automacao\" + txtTitulo.Value + @"\" + txtTitulo.Value + ".jpg";
                    System.IO.File.Move(cname, ciname);
                }
                else
                {

                }

                connection.Close();

            }

            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------


            if ( listGen.Value == "Banco De Dados")
            {

                connection.Open();

                var commando = new MySqlCommand($"INSERT INTO video_ (titulo,genero,descriçao,id_video) VALUES (@titulo,genero = 'Banco De Dados',@descriçao,id_video)", connection);
                commando.Parameters.Add(new MySqlParameter("titulo", txtTitulo.Value));
                commando.Parameters.Add(new MySqlParameter("descriçao", txtDesc.Value));
                commando.ExecuteNonQuery();

                string folder = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\banco-de-dados\" + txtTitulo.Value; //nome do diretorio a ser criado

                //Se o diretório não existir...

                if (!Directory.Exists(folder))
                {

                    //Criamos um com o nome folder
                    Directory.CreateDirectory(folder);

                }

                if (FileEp1.HasFile)
                {
                    FileEp1.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\banco-de-dados\" + txtTitulo.Value + @"\" + FileEp1.FileName);


                    string oldname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\banco-de-dados\" + txtTitulo.Value + @"\" + FileEp1.FileName;
                    string newname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\banco-de-dados\" + txtTitulo.Value + @"\" + "Episódio 1" + ".mp4";
                    System.IO.File.Move(oldname, newname);
                }
                else
                {

                }

                if (FileEp2.HasFile)
                {
                    FileEp2.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\banco-de-dados\" + txtTitulo.Value + @"\" + FileEp2.FileName);


                    string antname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\banco-de-dados\" + txtTitulo.Value + @"\" + FileEp2.FileName;
                    string novname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\banco-de-dados\" + txtTitulo.Value + @"\" + "Episódio 2" + ".mp4";
                    System.IO.File.Move(antname, novname);
                }
                else
                {

                }

                if (FileEp3.HasFile)
                {
                    FileEp3.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\banco-de-dados\" + txtTitulo.Value + @"\" + FileEp3.FileName);


                    string aname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\banco-de-dados\" + txtTitulo.Value + @"\" + FileEp3.FileName;
                    string nname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\banco-de-dados\" + txtTitulo.Value + @"\" + "Episódio 3" + ".mp4";
                    System.IO.File.Move(aname, nname);
                }
                else
                {

                }

                if (FileEp4.HasFile)
                {
                    FileEp4.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\banco-de-dados\" + txtTitulo.Value + @"\" + FileEp4.FileName);


                    string anname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\banco-de-dados\" + txtTitulo.Value + @"\" + FileEp4.FileName;
                    string noname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\banco-de-dados\" + txtTitulo.Value + @"\" + "Episódio 4" + ".mp4";
                    System.IO.File.Move(anname, noname);
                }
                else
                {

                }

                if (FileEp5.HasFile)
                {
                    FileEp5.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\banco-de-dados\" + txtTitulo.Value + @"\" + FileEp5.FileName);


                    string bname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\banco-de-dados\" + txtTitulo.Value + @"\" + FileEp5.FileName;
                    string boname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\banco-de-dados\" + txtTitulo.Value + @"\" + "Episódio 5" + ".mp4";
                    System.IO.File.Move(bname, boname);
                }
                else { }

                if (FileImg.HasFile)
                {
                    FileImg.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\banco-de-dados\" + txtTitulo.Value + @"\" + FileImg.FileName);
                    string cname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\banco-de-dados\" + txtTitulo.Value + @"\" + FileImg.FileName;
                    string ciname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\serie\banco-de-dados\" + txtTitulo.Value + @"\" + txtTitulo.Value + ".jpg";
                    System.IO.File.Move(cname, ciname);
                }
                else
                {

                }

                connection.Close();

            }
            else
            {

            }




        }
    }
}