<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CADASTRO.aspx.cs" Inherits="DEVPLUS.CADASTRO.CADASTRO" %>

<!DOCTYPE html>
 <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">

    <!-- Latest compiled JavaScript -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
    <script src="script.js"></script>
    <link rel="stylesheet" href="Stylecad.css">
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
            <div class="container-fluid " style="background-image: linear-gradient(350deg, #6a317c 0, #53276a9f 25%, #3a1c5694 50%, #24114244 75%, #13033015 100%); height: 100px;" >
                <div class="row">
                    <div class="col-sm-6"><img src="DevLogo.png" style="width: 200px; margin-top: -50px; margin-left: 90%; " alt=""></div>
                    <div class="col-sm-6"> </div>
                </div>
            
            </div>
            
    <div class="container-fluid pt-5" >
        <div class="row">
            <div class="col-lg-6">  <img class="imgfundo" src="3628732_612.jpg" alt=""></div>
            <div class="col-lg-6 text-center">

                <h1>Cadastro</h1>

                <label for="email">NOME:</label>

                     <asp:TextBox runat="server" ID="nome"  name="nome" CssClass="txt1" placeholder="Insira seu nome"></asp:TextBox>
                     <br>
                     <label for="email">EMAIL:</label>
                     <asp:TextBox runat="server" id="email" TextMode="email" name="email" CssClass="txt1" placeholder="Insira seu email"></asp:TextBox>
              
                    <br>
                     <label for="pwd">SENHA:</label>
                  
                     <asp:TextBox runat="server" id="password" TextMode="password" name="pwd" CssClass="txt1" placeholder="Insira sua senha"></asp:TextBox>
                     <br>


                     <label style="margin-left: -90px;"  for="pwdNv">CONFIRME SENHA:</label>
                  
                     <asp:TextBox runat="server" ID="Cpassword" TextMode="password" CssClass="txt1" name="pwdNv" placeholder="Insira sua senha novamente"></asp:TextBox>
                     <br>
                <asp:Button runat="server" class="btn1" name="btn" text="CADASTRAR"></asp:Button>

            </div>
        </div>
    
    </div>
   
        </div>
    





    </form>
</body>
</html>
