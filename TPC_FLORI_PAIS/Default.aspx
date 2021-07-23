<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPC_PAIS_FLORI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

    <div class="jumbotron mb-3 ">
        <div class="text-black">
            <h1>Remeras Estampadas</h1>
        </div>
    </div>
        <div class="input-group mb-3">
        <input type="search" class="form-control rounded" placeholder="Búsqueda por bombre de estampado o color de prenda." aria-label="search" name="search" id="search" aria-describedby="search-addon" />
        <button type="button" class="btn btn-outline-primary" runat="server" id="button1" onserverclick="Unnamed_ServerClick">Buscar</button>
    </div>
    <div class="row row-cols-1 row-cols-md-3">
        <%foreach (Dominio.Producto item in listaProducto){%>
        <div class="card mb-4">
            <div class="card-body">
                <img class="card-img-top position-absolute ml-3" src="<%=item.ImagenEstampado%>" alt="Card image" style="max-width: 80%; max-height: 80%">
                <img class="card-img-top" src="<%=item.ImagenColor%>" alt="Card image">
                <div class="card-body">
                    <h5 class="card-title"><%=item.Categoria%></h5>
                    <p class="card-text">En prenda de color: <%=item.Color%></p>
                    <div class="btn-group btn-group-sm">
                        <a href="ElegirTalle.aspx?id=<%=item.ID %>" class="btn btn-primary btn-sm mr-1 my-1"><i class="fas fa-shopping-cart mr-1"></i>Comprar</a>
                        <h4 class="card-text ml-2 p-1"><%=item.Precio.ToString("C")%></h4>
                        <!--<a class="btn btn-secondary btn-sm mr-1 my-1"><i class="fas fa-info-circle ml-1"></i>Ver Detalle</a>-->
                    </div>

                </div>
            </div>
        </div>
        <%} %>
    </div>
</asp:Content>
