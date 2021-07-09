<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ArmarRemera.aspx.cs" Inherits="TPC_PAIS_FLORI.ArmarRemera" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Diseña tu propia remera!</h1>
    <asp:Image ID="Imagenfondo" runat="server" Style="max-width: 60%; max-height: 60%;" alt="Card image" />
    <asp:Image ID="Imageestampado" runat="server" Style="max-width: 50%; max-height: 50%; position: fixed; right: 0; bottom: 520px; left: 730px" alt="Card image" />
    <div class="card-body">
        <asp:DropDownList ID="ddListaColores" runat="server" OnSelectedIndexChanged="ddListaColores_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
        <asp:DropDownList ID="ddListaEstampados" runat="server" OnSelectedIndexChanged="ddListaEstampados_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
        <asp:DropDownList ID="ddListaTalles" runat="server"></asp:DropDownList>
        <asp:TextBox TextMode="Number" ID="TextBox1" runat="server" min="1" MaxLength="20" placeholder="1" Text="1"></asp:TextBox>
        <asp:Button ID="AgregarCarrito" runat="server" Text="Agregar al Carrito" OnClick="AgregarCarrito_Click" />
    </div>

</asp:Content>
