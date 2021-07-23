<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FinalizarCompra.aspx.cs" Inherits="TPC_FLORI_PAIS.FinalizarCompra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

    <div class="jumbotron mb-3 ">
        <div class="text-black">
            <h1>Finalizar Compra</h1>
        </div>
    </div>
    <h3>Seleccione método de pago</h3>
    <asp:DropDownList ID="ddMetodoPago" runat="server">
        <asp:ListItem>Mercado Pago</asp:ListItem>
        <asp:ListItem>Transferencia</asp:ListItem>
        <asp:ListItem>Pago Facil</asp:ListItem>
    </asp:DropDownList>
    <br></br>
    <h3>Items a comprar:</h3>
    <table class="table">
        <thead>
            <tr>
                <th scope="col">Tipo</th>
                <th scope="col">Color</th>
                <th scope="col">Estampado</th>
                <th scope="col">Talle</th>
                <th scope="col">Precio Unitario</th>
                <th scope="col">Cantidad</th>
                <th scope="col">Precio Total por Producto</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repetidor" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("Categoria")%></td>
                        <td><%#Eval("Color")%></td>
                        <td><%#Eval("Estampado")%></td>
                        <td><%#Eval("Talle")%></td>
                        <td><%#Eval("Precio")%></td>
                        <td><%#Eval("Cantidad")%></td>
                        <td><%#Eval("PrecioxProducto")%></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>

        </tbody>
    </table>
    <asp:Button ID="btn_Comprar" CssClass="btn btn-primary btn-sm" OnClick="btn_Comprar_Click" runat="server" Text="Comprar" />
    <asp:Button ID="Atras" class="btn btn-secondary" runat="server" OnClick="Atras_Click" Text="Volver atrás" />

</asp:Content>
