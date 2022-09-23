<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Automacao.aspx.cs" Inherits="DEVPLUS.CATEGORIAS.Automacao.Automacao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" />
    <!-- CSS -->
    <link rel="stylesheet" href="https://unpkg.com/flickity@2/dist/flickity.min.css" />

    <!-- JavaScript -->
    <script src="https://unpkg.com/flickity@2/dist/flickity.pkgd.min.js"></script>
    <link href="Style.css" rel="stylesheet" />


    <!--CAROUSEL-->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Roboto|Open+Sans" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>

    <script src="scriptt.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-sm navbar-white " style="background-color: transparent;">
            <div class="container-fluid">
                <a class="navbar-brand" href="../../Tela Interna/Tela Interna.aspx">
                    <img src="DevLogo.png" style="width: 120px; margin-top: -8%;" alt="" /></a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#mynavbar">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="mynavbar">
                    <ul class="navbar-nav me-auto" style="margin-left: 5%; margin-top: 2%;">
                        <li class="nav-item">
                            <a class="nav-link me-5" style="color: white;" href="../../Video/Video.aspx">Video</a>
                        </li>

                        <li class="nav-item">
                            <a class="nav-link me-5" style="color: white;" href="../../Serie/Serie.aspx">Serie</a>
                        </li>

                        <li class="nav-item">
                            <a class="nav-link me-5" style="color: white;" href="javascript:void(0)">Minha Lista</a>
                        </li>
                         <li>
                         <div class="dropdown">
                <asp:button runat="server" ID="drop_genero" type="button" class="cate" data-bs-toggle="dropdown" Text=" Categorias ▼">
               
                </asp:button>
                <ul class="dropdown-menu">
                  <li><a class="dropdown-item" href="../Banco-de-dados/Banco de Dados.aspx">Banco-de-Dados</a></li>
                  <li><a class="dropdown-item" href="../Front-end/Front-end.aspx">Fron-End</a></li>
                  <li><a class="dropdown-item" href="Automacao.aspx">Automação</a></li>
                  <li><a class="dropdown-item" href="../Back-end/Back-End.aspx">Back-End</a></li>
                </ul>
                </div>
                    </li>

                    </ul>
                    


                  

                    <nav class="menu">
                        <input type="checkbox" class="menu-open" name="menu-open" id="menu-open" />
                        <label class="menu-open-button" for="menu-open">
                            <span class="hamburger hamburger-1"></span>
                            <span class="hamburger hamburger-2"></span>
                            
                        </label>

                       
                        <a href="#" class="menu-item">
                            <img src="do-utilizador.png" style="margin-top: -40%;" />
                        </a>
                        <a href="../../Tela Contato/Tela de Contato.aspx" class="menu-item">
                            <img src="chamada-telefonica.png" style="margin-top: -40%;" />
                        </a>
                    </nav>
                </div>
            </div>
        </nav>

        <div class="carroça" style="margin-top: -15%;margin-left: 17%">
            <div class="container" style="margin-top: 1%;">
                <div class="row">
                    <div class="col-md-12" style="margin-top: 1%;">
                        <div style="margin-top: 10%; margin-left: 40%">
                            <h2 style="color: white;">VIDEOS</h2>
                        </div>
                        <div id="myCarousel" class="carousel slide" data-ride="carousel" data-interval="0">
                            <!-- Carousel indicators -->
                            <ol class="carousel-indicators">
                                <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                                <li data-target="#myCarousel" data-slide-to="1"></li>
                                <li data-target="#myCarousel" data-slide-to="2"></li>
                                <li data-target="#myCarousel" data-slide-to="3"></li>
                                <li data-target="#myCarousel" data-slide-to="4"></li>
                            </ol>
                            <!-- Wrapper for carousel items --> 
                            <div runat="server" class="carousel-inner" id="lista_videos">
                            </div>
               <%--            <div class="carousel-inner">
                                <div class="item active">
                                    <div class="row">
                                        <div class="col-sm-3">
							<div class="thumb-wrapper">
								<span class="wish-icon"><i class="fa fa-heart-o"></i></span>
								<div class="img-box">
									<img src="../Upload/videos/front-end/Pedro Gangster.jpg" class="img-responsive" alt="">									
								</div>
								<div class="thumb-content">
									<h4>Pedro Gangster</h4>	
									<a href="../Tela de Exibição/Tela de Exibição.aspx?titulo=Pedro Gangster" class="btn btn-primary">ASSISTIR</a>
								</div>						
							</div>
						</div>
                                             <div class="col-sm-3">
							<div class="thumb-wrapper">
								<span class="wish-icon"><i class="fa fa-heart-o"></i></span>
								<div class="img-box">
									<img src="../Upload/videos/front-end/Pedro Gangster.jpg" class="img-responsive" alt="">									
								</div>
								<div class="thumb-content">
									<h4>Pedro Gangster</h4>	
									<a href="../Tela de Exibição/Tela de Exibição.aspx?titulo=Pedro Gangster" class="btn btn-primary">ASSISTIR</a>
								</div>						
							</div>
						</div>
                                             <div class="col-sm-3">
							<div class="thumb-wrapper">
								<span class="wish-icon"><i class="fa fa-heart-o"></i></span>
								<div class="img-box">
									<img src="../Upload/videos/front-end/Pedro Gangster.jpg" class="img-responsive" alt="">									
								</div>
								<div class="thumb-content">
									<h4>Pedro Gangster</h4>	
									<a href="../Tela de Exibição/Tela de Exibição.aspx?titulo=Pedro Gangster" class="btn btn-primary">ASSISTIR</a>
								</div>						
							</div>
						</div>
                                             <div class="col-sm-3">
							<div class="thumb-wrapper">
								<span class="wish-icon"><i class="fa fa-heart-o"></i></span>
								<div class="img-box">
									<img src="../Upload/videos/front-end/Pedro Gangster.jpg" class="img-responsive" alt="">									
								</div>
								<div class="thumb-content">
									<h4>Pedro Gangster</h4>	
									<a href="../Tela de Exibição/Tela de Exibição.aspx?titulo=Pedro Gangster" class="btn btn-primary">ASSISTIR</a>
								</div>						
							</div>
						</div>
                                    </div>
                                </div>
                                <div class="item">
                                    <div class="row">
                                             <div class="col-sm-3">
							<div class="thumb-wrapper">
								<span class="wish-icon"><i class="fa fa-heart-o"></i></span>
								<div class="img-box">
									<img src="../Upload/videos/front-end/Pedro Gangster.jpg" class="img-responsive" alt="">									
								</div>
								<div class="thumb-content">
									<h4>Pedro Gangster</h4>	
									<a href="../Tela de Exibição/Tela de Exibição.aspx?titulo=Pedro Gangster" class="btn btn-primary">ASSISTIR</a>
								</div>						
							</div>
						</div>
                                    </div>
                                </div>

                            </div>--%>

                            <!-- Carousel controls -->
                            <a class="carousel-control left" href="#myCarousel" data-slide="prev">
                                <i class="fa fa-angle-left"></i>
                            </a>
                            <a class="carousel-control right" href="#myCarousel" data-slide="next">
                                <i class="fa fa-angle-right"></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>






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
      
        <h2 style="position:absolute;top:100%;left:46%;color: white;">SERIES</h2>
      
      <div class="container-fluid text-center" style="margin-top:20%">
        <div class="carousel" data-flickity='{ "wrapAround": true, "autoPlay": true, "imagesLoaded":true }' style="width:100%;margin-left:0.7%" id="Carousel" runat="server">
             
      </div>
          </div>

        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    </form>
</body>
</html>
