<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ArmarRemera.aspx.cs" Inherits="TPC_PAIS_FLORI.ArmarRemera" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <div class="jumbotron mb-3 ">
        <div class="text-black">
            <h1>Diseña tu propia remera!</h1>
        </div>
    </div>

    <asp:Image ID="Imagenfondo" runat="server" Style="max-width: 60%; max-height: 60%;" alt="Card image" />
    <asp:Image ID="Imageestampado" runat="server" Style="max-width: 50%; max-height: 50%; position: fixed; right: 0; bottom: 380px; left: 730px" alt="Card image" />
    <table class="table mb-2">
        <thead>
            <tr>
                <th scope="col" style="-ms-wrap-margin: initial">Color</th>
                <th scope="col">Estampado</th>
                <th scope="col">Talle</th>
                <th scope="col">Cantidad</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>
                    <asp:DropDownList ID="ddListaColores" runat="server" OnSelectedIndexChanged="ddListaColores_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="ddListaEstampados" runat="server" OnSelectedIndexChanged="ddListaEstampados_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
                <td>
                    <asp:DropDownList ID="ddListaTalles" runat="server"></asp:DropDownList></td>
                <td>
                    <asp:TextBox TextMode="Number" ID="TextBox1" runat="server" min="1" MaxLength="20" placeholder="1" Text="1"></asp:TextBox></td>
            </tr>
        </tbody>
    </table>

    <asp:Button ID="AgregarCarrito" runat="server" class="btn btn-primary" Text="Agregar al Carrito" OnClick="AgregarCarrito_Click" />
    <asp:Button ID="Atras" class="btn btn-secondary" runat="server" OnClick="Unnamed_ServerClick" Text="Volver atrás" />

</asp:Content>





