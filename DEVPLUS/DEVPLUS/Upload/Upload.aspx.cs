using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySqlConnector;
namespace DEVPLUS.Upload
{
    public partial class Upload : System.Web.UI.Page
    {
       
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

          


            if (FileUpLoad1.HasFile && listGen.Value== "Front-End")
            {
                

                FileUpLoad1.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + FileUpLoad1.FileName);
                string oldname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + FileUpLoad1.FileName;
                string newname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\front-end\" + txtTitulo.Value+".mp4";

                System.IO.File.Move(oldname, newname);


            }
           
            if (FileUpLoad1.HasFile && listGen.Value == "Back-End")
            {

                FileUpLoad1.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\back-end\" + FileUpLoad1.FileName);
                string oldname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\back-end\" + FileUpLoad1.FileName;
                string newname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\back-end\" + txtTitulo.Value + ".mp4";
                System.IO.File.Move(oldname, newname);

            }
           
            if (FileUpLoad1.HasFile && listGen.Value == "Automação Python")
            {


                FileUpLoad1.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\automacao\" + FileUpLoad1.FileName);
                string oldname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\automacao\" + FileUpLoad1.FileName;
                string newname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\automacao\" + txtTitulo.Value + ".mp4";
                System.IO.File.Move(oldname, newname);

            }
          
            if (FileUpLoad1.HasFile && listGen.Value == "Banco De Dados")
            {

                FileUpLoad1.SaveAs(@"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\banco-de-dados\" + FileUpLoad1.FileName);
                string oldname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\banco-de-dados\" + FileUpLoad1.FileName;
                string newname = @"C:\Users\ALUNO\Desktop\Pedro\DevPlus\DEVPLUS\Upload\videos\banco-de-dados\" + txtTitulo.Value + ".mp4";
                System.IO.File.Move(oldname, newname);

            }
            else
            {

            }
            
        }

        

        protected void ep1_Click(object sender, EventArgs e)
        {

        }

        protected void ep2_Click(object sender, EventArgs e)
        {

        }

        protected void ep3_Click(object sender, EventArgs e)
        {

        }

        protected void ep4_Click(object sender, EventArgs e)
        {

        }

        protected void ep5_Click(object sender, EventArgs e)
        {

        }

        protected void ep6_Click(object sender, EventArgs e)
        {

        }

        protected void Ok_Click(object sender, EventArgs e)
        {
            if (listTip.Value == "Vídeo")
            {
                serie.Style.Value = "display:none";
                serieend.Style.Value = "display:none";
                video.Style.Value = "display:block";

            }
            else
            {
                serie.Style.Value = "display:block";
                serieend.Style.Value = "display:block";
                video.Style.Value = "display:none";

            }

        }
    }
}