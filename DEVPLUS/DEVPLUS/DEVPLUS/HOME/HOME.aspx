<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HOME.aspx.cs" Inherits="DEVPLUS.HOME.HOME" %>

<!DOCTYPE html>
 <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">

<!-- Latest compiled JavaScript -->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
<script src="script.js"></script>
<link rel="stylesheet" href="style.css">
<link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Prompt&display=swap" rel="stylesheet">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <div class="initalpage">
        <img class="imgfundo" src="rear-view-of-programmer-working-all-night-long.jpg" alt="">
<div class="container-fluid" >
    <div class="row">
        <div class="col-sm-6"><img src="DevLogo.png" style="width: 300px; margin-top: -30px; " alt=""></div>
        <div class="col-sm-6"> <asp:Button runat="server" style="margin-top: 95px; margin-left:610px;" CssClass="btnEnt" text="ENTRAR" OnClick="Unnamed_Click1"></asp:Button></div>
    </div>

</div>
<div class="container-sm text-center pt-3">
<h1 style="font-size: 40pt;" > Desde a programação basica até a <br> mais avançada.O céu é o limite!</h1>
<h5>Pronto para assistir? Informe seu email para criar ou reiniciar sua assinatura.</h5>
<div class="row pt-1">
   <asp:TextBox runat="server" ID="txtEmail" CssClass="txtEmail" TextMode="Email" placeholder="Insira seu email" ></asp:TextBox>
   
   <asp:Button runat="server" CssClass="btnGo" text="VAMOS LÁ" onclick="Unnamed_Click"></asp:Button >

</div>
</div>



    </div>
    </form>
</body>
</html>
