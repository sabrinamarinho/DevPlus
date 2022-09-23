<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tela de Contato.aspx.cs" Inherits="DEVPLUS.Contato.Tela_de_Contato" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
    <link rel="preconnect" href="https://fonts.googleapis.com">
   
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
<link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css">
<!-- CSS -->
<link rel="stylesheet" href="https://unpkg.com/flickity@2/dist/flickity.min.css">

<!-- JavaScript -->
<script src="https://unpkg.com/flickity@2/dist/flickity.pkgd.min.js"></script>
    <link rel="stylesheet" href="estilo.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-sm navbar-white " style="background-color: transparent;">
        <div class="container-fluid">
            <a class="navbar-brand" href="javascript:void(0)"><img src="DevLogo.png" style="width: 120px; " alt=""></a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#mynavbar">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="mynavbar">
                <ul class="navbar-nav me-auto" style="margin-left: 5%;">
                    <li class="nav-item">
                        <a class="nav-link me-5" style="color :white; " href="javascript:void(0)">Video</a>
                    </li>

                    <li class="nav-item">
                        <a class="nav-link me-5" style="color:white; " href="javascript:void(0)">Serie</a>
                    </li>

                    <li class="nav-item">
                        <a class="nav-link me-5" style="color:white;" href="javascript:void(0)">Minha Lista</a>
                    </li>


                    <div class="dropdown">
                        <button type="button" class="cate" data-bs-toggle="dropdown">
                            Categorias ▼
                        </button>
                        <ul class="dropdown-menu">
                            <li><a class="dropdown-item" href="#">Link 1</a></li>
                            <li><a class="dropdown-item" href="#">Link 2</a></li>
                            <li><a class="dropdown-item" href="#">Link 3</a></li>
                        </ul>
                    </div>
                </ul>



                <div class="ex-busca cinco">
                    <form action=" " method="post" onsubmit="return false">
                        <div class="busquinha-exemplo w100" style="position:absolute;left: 1080px;top: 13px;">
                            <input class="inp1" type="search" id="busca5" name="q">
                            <button class="btn1" type="submit" id="btn-busca"><img
                                    src="search-free-icon-font (1).png" /></button>
                        </div>
                    </form>
                </div>

                <nav class="menu">
                    <input type="checkbox" href="#" class="menu-open" name="menu-open" id="menu-open" />
                    <label class="menu-open-button" for="menu-open">
                        <span class="hamburger hamburger-1"></span>
                        <span class="hamburger hamburger-2"></span>
                        <span class="hamburger hamburger-3"></span>
                    </label>

                    <a href="#" class="menu-item"><img src="definicoes.png" style="margin-top:-40%;"/> </a>
                    <a href="#" class="menu-item"> <img src="do-utilizador.png" style="margin-top:-40%;"/></i> </a>
                    <a href="#" class="menu-item"><img src="chamada-telefonica.png" style="margin-top:-40%;"/> </i> </a>


                </nav>
            
                
            </div>
        </div>
    </nav>
    <div class="container-sm text-center">
    </div>
     <div class="container-sm text-center pt-5">
        <h1 style="color: aliceblue;"> LÍDERES:</h1>
    </div> 

    <br/>

    <div class="container-sm text-center">
        
        <div class="row">
            <div class="col-6">
        <img class="img1" style="border: solid 3px red; width:80%" src="fessor.jpeg" alt=""> <br /> <br />
         <h1 style="color: white;">OMEGA do MUNDO</h1>
         </div>
            <div class="col-6 pt-5">
         <img class="img1" style="border: solid 3px #0b89ff; width: 60%;" src="luigi.jpg" alt=""> <br> <br>
            <h2 style="color: white;">CEO da Empresa</h2>
                 </div>
        </div>
  <div class="container-sm text-center pt-5">
        <h2 style="color: aliceblue;"> EQUIPE DE PROGRAMADORES:</h2>
    </div> 
        <div class="row pt-5 text-center">
            <div class="col-2 pt-5"> <img class="img1" src="caique.jpg" alt=""> </div>
            <div class="col-2 pt-5"> <img class="img1" src="joao.jpg" alt=""> </div>
            <div class="col-4"> <img class="img1" src="pedro.jpg" alt=""> <br /> <br />
                <h4 style="color: white;">Líder</h4>
            </div>
            <div class="col-2 pt-5"> <img class="img1" src="kevin.jpg" alt=""> </div>
            <div class="col-2 pt-5"> <img class="img1" src="sabrina.jpg" alt=""> </div>
            
        </div>
    </div>

    <div class="container-sm pt-5 text-center"> 
        <h2 style="color:aliceblue; text-align: center;"> CONTATOS:</h2>
        <div class="row pt-5">
            <div class="col-3"> <a href="https://www.youtube.com/watch?v=EZEfN5z8Mlg"><img class="contat" src="circle-phone.png" alt=""></a> </div>
            <div class="col-3"> <a href="https://www.youtube.com/watch?v=LXaQD4-kFws"><img class="contat" src="envelope.png" alt=""></a> </div>
            <div class="col-3"> <a href="https://www.youtube.com/watch?v=BPfkK7bcyfE"><img class="contat" src="facebook.png" alt=""></a> </div>
            <div class="col-3"> <a href="https://www.youtube.com/watch?v=WdoXZf-FZyA&list=RDEMSpqz7CZCEvKk4NwiF-nwDQ&index=29"><img class="contat" src="instagram.png" alt=""> </a></div>
        </div>
    </div>

    <div class="container-sm text-center pt-5 pb-5" style="background-color: #7940ff; margin-top: 5%; margin-bottom: 5%; width: 600px; border-radius: 10px; ">
    
        <h1>Feedback</h1>
        <input type="text" class="txtFeed" name="" value="" placeholder="Insira seu feedback ou dúvida...">


    </div>
    </form>
</body>
</html>
