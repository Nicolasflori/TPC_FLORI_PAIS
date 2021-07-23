
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" enableEventValidation="false" CodeBehind="CarritoDeCompra.aspx.cs" Inherits="TPC_PAIS_FLORI.CarritoDeCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

    <div class="jumbotron mb-3 ">
        <div class="text-black">
            <h1>Carrito de Compras</h1>
        </div>
    </div>

	 
    <table class="table">
        <thead>
            <tr>
                <th scope="col">Tipo</th>
                <th scope="col">Color</th>
                <th scope="col">Estampado</th>
                <th scope="col">Talle</th>
                <th scope="col">Precio Unitario</th>
                <th scope="col">Cantidad</th>
                <th scope="col">Precio Total</th>
                <th scope="col">Eliminar del Carrito</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repetidor" runat="server" OnItemCommand="Repetidor_ItemCommand" >
                <ItemTemplate>
                    <tr>   
                        <td><%#Eval("Categoria")%></td>
                        <td><%#Eval("Color")%></td>
                        <td><%#Eval("Estampado")%></td>
                        <td><%#Eval("Talle")%></td>
                        <td><%#Eval("Precio")%></td>
                        <td><%#Eval("Cantidad")%></td>
                        <td><%#Eval("PrecioxProducto")%></td>
                        <td><asp:LinkButton ID="lnkUpdate" Text="Eliminar" runat="server" CommandName="DeleteRow" CommandArgument='<%# Container.ItemIndex %>'/></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>

        </tbody>
    </table>  
    <asp:Button ID="btn_Comprar" CssClass="btn btn-primary btn-sm mr-1 my-1" OnClick="btn_Comprar_Click" runat="server" Text="Comprar" />

     <%-- <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModal"><i class="fas fa-shopping-cart mr-1"></i>Comprar</button>--%>
       <button class="btn btn-secondary" runat="server" onserverclick="Unnamed_ServerClick">Agregar más productos</button>

    
</asp:Content>
