﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="PerfilUsuario.perfil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="stylesheet" href="style.css">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css">
    <!-- CSS -->
    <link rel="stylesheet" href="https://unpkg.com/flickity@2/dist/flickity.min.css">

    <!-- JavaScript -->
    <script src="https://unpkg.com/flickity@2/dist/flickity.pkgd.min.js"></script>
    <title>Document</title>
</head>
<body>
    <form runat="server" id="Form1">
        <nav class="navbar navbar-expand-sm navbar-white " style="background-color: transparent;">
            <div class="container-fluid">
                <a class="navbar-brand" href="javascript:void(0)">
                    <img src="DevLogo.png" style="width: 120px;" alt=""></a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#mynavbar">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="mynavbar">
                    <ul class="navbar-nav me-auto" style="margin-left: 5%;">
                        <li class="nav-item">
                            <a class="nav-link me-5" style="color: white;" href="javascript:void(0)">Video</a>
                        </li>

                        <li class="nav-item">
                            <a class="nav-link me-5" style="color: white;" href="javascript:void(0)">Serie</a>
                        </li>

                        <li class="nav-item">
                            <a class="nav-link me-5" style="color: white;" href="javascript:void(0)">Minha Lista</a>
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
                            <div class="busquinha-exemplo w100" style="position: absolute; left: 1090px; top: 40px;">
                                <input class="inp1" type="search" id="busca5" name="q">
                                <button class="btn1" type="submit" id="btn-busca">
                                    <img src="search-free-icon-font (1).png" /></button>
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

                        <a href="#" class="menu-item">
                            <img src="definicoes.png" style="margin-top: -40%;">
                        </a>
                        <a href="#" class="menu-item">
                            <img src="do-utilizador.png" style="margin-top: -40%;"></i> </a>
                        <a href="#" class="menu-item">
                            <img src="chamada-telefonica.png" style="margin-top: -40%;">
                            </i> </a>

                    </nav>

                </div>
            </div>
        </nav>
        <div class="container">
            <div class="row" style="margin-top: 3%">
                <div class="col-sm-4">
                </div>
                <div class="col-sm-4" style="z-index: 1;">
                    <img src="icone-perfil-usuario2.png" alt="icone Perfil" style="width: 200px; margin-left: 25%;"><br>
                    <br>
                    <label for="name" style="color: white">Nome:</label><br>
                    <asp:TextBox runat="server" ID="txtNome" disabled="true " class="form-control form-control-lg"></asp:TextBox><br>
                    <label for="e-mail" style="color: white">E-mail:</label>
                    <asp:TextBox runat="server" ID="txtEmail" class="form-control form-control-lg" disabled="true"></asp:TextBox><br>
                    <label for="senha1" style="color: white">Senha:</label>
                    <asp:TextBox runat="server" ID="txtsenha" TextMode="Password" class="form-control form-control-lg" disabled="true"></asp:TextBox><br>
                    <asp:button runat="server" ID="btnAlterarCadastro" class="btn btn-secondary" style="margin-left: 10%;" OnClick="btnAlterarCadastro_Click" Text="Alterar cadastro"></asp:button>
                    <asp:Button runat="server" ID="btnAlterarSenha" OnClick="btnAlterarSenha_Click" class="btn btn-secondary" style="margin-left: 16%;" Text="Alterar senha"></asp:Button>
                </div>
            </div>
        </div>
        <div class="recad">
            <label for="name" style="color: white; margin-top: 7%; margin-left: 18%;">Nome:</label>
            <asp:TextBox runat="server" ID="txtAlteraNomeUsuario" class="form-control form-control-lg" style="width: 400px; margin-left: 17%"></asp:TextBox><br>
            <label for="e-mail" style="color: white; margin-left: 18%;">E-mail:</label>
            <asp:TextBox runat="server" ID="txtAlteraEmailUsuario" class="form-control form-control-lg" style="width: 400px; margin-left: 17%;"></asp:TextBox><br>
            <br>
            <asp:Button runat="server" ID="btnAtualizarCadastro" OnClick="btnAtualizarCadastro_Click" ext="Atualizar cadastro" class="btn btn-secondary" style="margin-left: 38%;"></asp:Button>
        </div>
        <div class="recadsenha">
            <label for="name" style="color: white; margin-top: 6%; margin-left: 18%;">Senha atual:</label>
            <asp:TextBox runat="server" ID="txtSenhaAtual" TextMode="Password" class="form-control form-control-lg" style="width: 400px; margin-left: 17%"></asp:TextBox><br>
            <label for="e-mail" style="color: white; margin-left: 18%;">Nova senha:</label>
            <asp:TextBox runat="server" ID="txtNovaSenha" TextMode="Password" class="form-control form-control-lg" style="width: 400px; margin-left: 17%;"></asp:TextBox><br>
            <label for="e-mail" style="color: white; margin-left: 18%;">Confirme sua senha:</label>
            <asp:TextBox runat="server" ID="txtConfirmarSenha" class="form-control form-control-lg" style="width: 400px; margin-left: 17%;"></asp:TextBox><br>
            <br>
            <asp:Button runat="server" ID="btnAtualizarSenha" OnClick="btnAtualizarSenha_Click" Text="Atualizar senha" class="btn btn-secondary" style="margin-left: 38%;"></asp:Button>
        </div>
    </form>
</body>
</html>
