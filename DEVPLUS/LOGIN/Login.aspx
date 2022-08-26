<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DEVPLUS.LOGIN.Login" %>

<!DOCTYPE html>
 <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">

    <!-- Latest compiled JavaScript -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
    <script src="script.js"></script>
    <link rel="stylesheet" href="Logstyle.css">
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
            <img class="imgfundo" src="close-up-image-of-programer-working-at-his-desk-in-office.jpg" alt="">
    <div class="container-fluid" >
        <div class="row">
            <div class="col-sm-6 "><img src="DevLogo.png" style="width: 300px; margin-top:-30px;" alt=""></div>
          
        </div>
    
    </div>
    <div class="container-sm text-center pt-1">
    <h1 style="font-size: 40pt;margin-top: -80px; " > LOGIN</h1>
    <div class="container-lg text-center pt-1">
        <label class="label1">EMAIL OU NOME:</label>
        <br>
       <asp:TextBox runat="server" TextMode="email" name="emailorname" CssClass="txtEmail" placeholder="Insira seu email ou nome" value=""></asp:TextBox>
       <br>
       <label class="label">SENHA:</label>
       <br>
       <asp:TextBox runat="server" TextMode="password" name="password" CssClass="password" placeholder="senha" value=""></asp:TextBox>
       <br>
       <asp:Button runat="server" CssClass="btnGo" text="VAMOS LÁ"></asp:Button >
    </div>
    </div>
    
    
    
        </div>
    </form>
</body>
</html>
