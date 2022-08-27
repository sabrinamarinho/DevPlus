<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastrar.aspx.cs" Inherits="DevPlus.Cadastrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox runat="server" ID="teste_email" placeholder="digite email" ></asp:TextBox>
    <br />
    <br />
    <asp:TextBox runat="server" ID="teste_senha" placeholder="digite a senha"></asp:TextBox>
    <br />
    <br />
    <asp:TextBox runat="server" ID="teste_senha2" placeholder="senha novamente"></asp:TextBox>
    <br />
    <br />
    <asp:TextBox runat="server" ID="nome_texte" placeholder="nome usuario"></asp:TextBox>
    <br />
    <br />
    <asp:Button runat="server" ID="cadastro" OnClick="cadastro_Click" Text="cadastrar" />

</asp:Content>
    