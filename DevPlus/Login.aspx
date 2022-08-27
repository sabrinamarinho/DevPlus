<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DevPlus.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox runat="server" ID="email" placeholder="email ou nome do usuario"></asp:TextBox>
    <br />
    <br />
    <asp:TextBox runat="server" ID="senha" placeholder="senha"></asp:TextBox>
    <br />
    <br />
    <asp:Button runat="server" ID="login" OnClick="login_Click" text="login" />

</asp:Content>
