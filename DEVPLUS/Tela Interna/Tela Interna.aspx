<%@ Page Language="C#" AutoEventWireup="true"  EnableEventValidation="false" CodeBehind="Tela Interna.aspx.cs" Inherits="DEVPLUS.Tela_Interna.Tela_Interna" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
    <link rel="preconnect" href="https://fonts.googleapis.com"/>
    <link rel="stylesheet" href="sty.scss">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin/>
<link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css"/>
<!-- CSS -->
<link rel="stylesheet" href="https://unpkg.com/flickity@2/dist/flickity.min.css"/>

<!-- JavaScript -->
<script src="https://unpkg.com/flickity@2/dist/flickity.pkgd.min.js"></script>
    <link rel="stylesheet" href="style.css">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-sm navbar-white " style="background-color: transparent;"> 
        <div class="container-fluid">
          <a class="navbar-brand" href="Tela Interna.aspx"><img src="DevLogo.png" style="width: 120px; " alt=""></a>
          <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#mynavbar" >
            <span class="navbar-toggler-icon"></span>
          </button>
          <div class="collapse navbar-collapse" id="mynavbar">
            <ul class="navbar-nav me-auto" style="margin-left: 5%;">
              <li class="nav-item">
                <a class="nav-link me-5" style="color :white; " href="../Video/Video.aspx">Video</a>
              </li>
              
              <li class="nav-item" >
                <a class="nav-link me-5"  style="color:white; " href="../Serie/Serie.aspx">Serie</a>
              </li>
             
              <li class="nav-item">
                <a class="nav-link me-5"  style="color:white;" href="javascript:void(0)">Minha Lista</a>
              </li>

                <li>
                    <div class="dropdown">
                <asp:button runat="server" ID="drop_genero" type="button" class="cate" data-bs-toggle="dropdown" Text=" Categorias ▼">
               
                </asp:button>
                <ul class="dropdown-menu">
                  <li><a class="dropdown-item" href="../CATEGORIAS/Banco-de-dados/Banco de Dados.aspx">Banco-de-Dados</a></li>
                  <li><a class="dropdown-item" href="../CATEGORIAS/Front-end/Front-end.aspx">Fron-End</a></li>
                  <li><a class="dropdown-item" href="../CATEGORIAS/Automacao/Automacao.aspx">Automação</a></li>
                  <li><a class="dropdown-item" href="../CATEGORIAS/Back-end/Back-End.aspx">Back-End</a></li>
                </ul>
                </div>
                </li>
              
            </ul>
           
            

            <div class="ex-busca cinco">
              <form action="" method="post" onsubmit="return false">
                 <div class="busquinha-exemplo w100" style="position:absolute;left:1090px;top:40px;">
                  <input class="inp1" type="search" id="busca5" name="q">
                  <button class="btn1" type="submit" id="btn-busca"><img src="search-free-icon-font (1).png"/></button>
                 </div>   
              </form>
              </div>
           
<nav class="menu">
  <input type="checkbox" href="#" class="menu-open" name="menu-open" id="menu-open"/>
  <label class="menu-open-button" for="menu-open">
    <span class="hamburger hamburger-1"></span>
    <span class="hamburger hamburger-2"></span>
  
  </label>   
    
  <a  class="menu-item"> <asp:ImageButton runat="server" OnClick="Unnamed_Click" ImageUrl="do-utilizador.png"  style="margin-top:-40%;" /></i> </a>
  <a href="../Tela Contato/Tela de Contato.aspx" class="menu-item"><img src="chamada-telefonica.png" style="margin-top:-40%;"> </i> </a>

</nav>

              
<!-- filters -->
<svg xmlns="http://www.w3.org/2000/svg" version="1.1">
    <defs>
      <filter id="shadowed-goo">
          
          <feGaussianBlur in="SourceGraphic" result="blur" stdDeviation="10" />
          <feColorMatrix in="blur" mode="matrix" values="1 0 0 0 0  0 1 0 0 0  0 0 1 0 0  0 0 0 18 -7" result="goo" />
          <feGaussianBlur in="goo" stdDeviation="3" result="shadow" />
          <feColorMatrix in="shadow" mode="matrix" values="0 0 0 0 0  0 0 0 0 0  0 0 0 0 0  0 0 0 1 -0.2" result="shadow" />
          <feOffset in="shadow" dx="1" dy="1" result="shadow" />
          <feBlend in2="shadow" in="goo" result="goo" />
          <feBlend in2="goo" in="SourceGraphic" result="mix" />
      </filter>
      <filter id="goo">
          <feGaussianBlur in="SourceGraphic" result="blur" stdDeviation="10" />
          <feColorMatrix in="blur" mode="matrix" values="1 0 0 0 0  0 1 0 0 0  0 0 1 0 0  0 0 0 18 -7" result="goo" />
          <feBlend in2="goo" in="SourceGraphic" result="mix" />
      </filter>
    </defs>
</svg>
          </div>
        </div>
      </nav>
        <div class="container-fluid text-center">
      <div class="carousel" data-flickity='{ "wrapAround": true, "autoPlay": true, "imagesLoaded":true }' style="height: 600px; width:100%" id="Carousel" runat="server">
       
        
      </div>
    </div>
    </form>
</body>
</html>
