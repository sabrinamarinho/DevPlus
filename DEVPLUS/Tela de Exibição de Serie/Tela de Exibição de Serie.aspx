<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tela de Exibição de Serie.aspx.cs" Inherits="DEVPLUS.Tela_de_Exibição_de_Serie.Tela_de_Exibição_de_Serie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="stylexib.css">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <a onclick="window.location='../Tela Interna/Tela Interna.aspx'"> <img src="arrow-left-free-icon-font (1).png" alt="" style="position: absolute;top: 5%;left: 5%;width: 70px;" ></a> 
    <div class="col-lg-6 text-center" style="margin-left: -5%;margin-top: 10%;">
<h1 runat="server" class="titulo" id="titulo_v" >TITULO DO VIDEO</h1>
<p runat="server" style="width:300px;margin-left:30%" class="descricao" id="descricao_v" >Aqui esta a descrição do video seu zé mané</p>
</div>

<div class="col-lg-6">
    <video width="900px" height="700px" poster="DevLogo.png" style="position: absolute;top: 5%;left: 40%;" controls>
      <source runat="server" id="vidin" src="TESTE.mp4" type="video/mp4" />
       
      
    </video>
    </div>
         <div class="" style="margin-left: 10%">
                            <h3 class="pb-1 pt-3">Episódios</h3>


 <asp:DropDownList id="DropList" Runat="Server" OnSelectedIndexChanged="DropList_SelectedIndexChanged" AutoPostBack="true" >
  <asp:ListItem Text="EPISODIO 1" Value="1"/>
  <asp:ListItem Text="EPISODIO 2" Value="2"/>
  <asp:ListItem Text="EPISODIO 3" Value="3"/>
  <asp:ListItem Text="EPISODIO 4" Value="4"/>
  <asp:ListItem Text="EPISODIO 5" Value="5"/>
     <asp:ListItem Text="EPISODIO 6" Value="6"/>
</asp:DropDownList>
                        </div>
    <div class="container" style="position: absolute; margin-top: 18%;left: 19%;">
        <div class="center">
          <button class="btn">
            <svg width="180px" height="60px" viewBox="0 0 180 60" class="border">
              <polyline points="179,1 179,59 1,59 1,1 179,1" class="bg-line" />
              <polyline points="179,1 179,59 1,59 1,1 179,1" class="hl-line" />
            </svg>
            <span>ASSISTIR MAIS TARDE</span>
          </button>
        </div>
      </div>
    </form>
</body>
</html>
