<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ElegirTalle.aspx.cs" Inherits="TPC_FLORI_PAIS.ElegirTalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Continuar con la Compra</h1>

    <asp:Image ID="Imagenfondo" runat="server" Style="max-width: 60%; max-height: 60%;" alt="Card image" />
    <asp:Image ID="Imageestampado" runat="server" Style="max-width: 50%; max-height: 50%; position:fixed; right:0; bottom:520px; left:730px" alt="Card image" />
    <div class="card-body">
        <h5>
            <asp:Label ID="lblCategoria" runat="server" Text="Label" Font-Size="30px"></asp:Label></h5>
        <p>
            Descripción:
            <asp:Label ID="LblEstampado" runat="server" Text="Label" Font-Size="20px"></asp:Label>
        </p>
        <h6 class="mb-2">Precio: $<span><asp:Label ID="LblPrecio" runat="server" Text="Label" Font-Size="15px"></asp:Label></span></h6>
        <p class="card-text"><small class="text-muted"></small></p>
        <asp:DropDownList ID="ddListaTalles" runat="server"></asp:DropDownList>
        <asp:TextBox TextMode="Number" ID="TextBox1" runat="server" min="1" MaxLength="20" placeholder="1" Text="1"></asp:TextBox>
        <asp:Button ID="AgregarCarrito" runat="server" class="btn btn-primary" Text="Agregar al Carrito" OnClick="buttonAgregarCarrito_Click" />
        <asp:Button ID="Atras" class="btn btn-secondary" runat="server" OnClick="Unnamed_ServerClick" Text="Volver atrás" />
    </div>

</asp:Content>
