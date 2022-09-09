﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="DEVPLUS.Upload.Upload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
  <link rel="stylesheet" href="style.css">
<link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Prompt&display=swap" rel="stylesheet">
  <link rel="stylesheet" href="style.css">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>



             <h1 class="text-center pb-5">Upload de Vídeos</h1>

    <div class="container">
        <div class="row">
            <div class="col-6">
                <form action="/action_page.php">
        
                    <p>
                       
                       <h3 class="pb-1">Titulo:</h3>
                       
                        <input runat="server" id="txtTitulo" type="text" name="sintomas" size="48" class="txtTitulo" /><br><br>
                       
                        </form>
                     
                     
                    </p>
                    <form action="/action_page.php">
                        <h3 class="pb-1 pt-3">Descrição:</h3>
                        
                        <textarea runat="server"  style="resize: none;" class="txtDesc" name="" id="txtDesc" cols="50" rows="6" ></textarea>
                        
                    </form>
                    
                 
                 <div id="serieend" runat="server" >
                 
                     </div>
            </div>
            <div class="col-6 pt-5"> 
               
            <div class="col-6" style="margin-left:10%">
                    <h3 class="pb-1 pt-3">Gênero:</h3>
               
                
                    <select runat="server" id="listGen" class="listGen form-select"> 
                        <option>Front-End</option>
                        <option>Back-End</option>
                        <option>Automação Python</option>
                        <option>Banco De Dados</option>
                      </select>
                 </div>
                 <div class="col-6" style="margin-left:10%">
                <h3 class="pb-1 pt-3">Tipo:</h3>
               
                
                    <select runat="server" id="listTip" class="listGen form-select" > 
                        <option>Vídeo</option>
                        <option>Série</option>
                      
                      </select>

                     <br />
                       <asp:Button  id = "Ok" CssClass="btnOk" style=" height: 50px; width:200px; " Text = "Ok" OnClick="Ok_Click" runat = "server"/>
                 
                      </div>
                    

                <div id="video" runat="server" >
                   <asp:FileUpload CssClass="btnConcluir" id = "FileUpLoad1" runat ="server"/>  
    <asp:Button  id = "BtnUpload" CssClass="btnConcluir" style=" height: 50px;" Text = "Fazer upload do arquivo" OnClick="BtnUpload_Click" runat = "server"/>
                </div>
        </div>


        <div class="container-sm " style="background-color: rgb(36, 36, 36); border-radius: 20px;" id="serie" runat="server" >
          <asp:Button Text="X" runat="server" ID="btnBack" OnClick="btnBack_Click" style=" margin-left: 96.5%;
    margin-top: 1%;
    color: white;
    background-color: rgb(36, 36, 36);
    border: none;
    font-size: 20pt;" />
             <div class="row">
            <div class="col-6">
                 <h4 class="pt-5">Imagem para Capa:</h4>
                 <asp:FileUpload CssClass="btnConcluir" id = "FileImg" runat ="server"/>  
            <h4 class="pt-5">Episodio 1:</h4>
                 <asp:FileUpload CssClass="btnConcluir" id = "FileEp1" runat ="server"/>  
   
                 <h4 class="pt-5">Episodio 2:</h4>
                 <asp:FileUpload CssClass="btnConcluir" id = "FileEp2" runat ="server"/>  

               
                </div>
                 <div class="col-6">
                       <h4 class="pt-5">Episodio 3:</h4>
                 <asp:FileUpload CssClass="btnConcluir" id = "FileEp3" runat ="server"/>  
   
                <h4 class="pt-5">Episodio 4:</h4>
                 <asp:FileUpload CssClass="btnConcluir" id = "FileEp4" runat ="server"/>  
    
            <h4 class="pt-5">Episodio 5:</h4>

                 <asp:FileUpload CssClass="btnConcluir" id = "FileEp5" runat ="server"/>  
    
                  
    <asp:Button  id = "UpSerie" CssClass="btnConcluir" style=" height: 50px; margin-bottom:5%;margin-top:5%" Text = "Fazer upload dos episódios" OnClick="UpSerie_Click" runat = "server"/>
                </div>
                 </div>
            </div>

        </div>
    </div>
    

        </div>
    </form>
</body>
</html>
