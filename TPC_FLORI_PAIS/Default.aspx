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

    <div class="row row-cols-1 row-cols-md-3" >
        <% Negocio.NegocioColores NegocioColores = new Negocio.NegocioColores();
            Negocio.NegocioCategorias NegocioCategorias = new Negocio.NegocioCategorias();
            Negocio.NegocioEstampado NegocioEstampado = new Negocio.NegocioEstampado();

            string varColor = null;
            string varCategoria = null;
            string varEstampado = null;

            foreach (Dominio.ProductoPreCargado item in listaProductoPreCargado)
            {
                varColor = NegocioColores.descripcionxid(item.IDColor);
                varCategoria = NegocioCategorias.descripcionxid(item.ID);
                varEstampado = NegocioEstampado.imagenxid(item.IDEstampado);
                string imagenRemera = "../recursos/Remera/"+ varColor + ".jpg";
                string imagenEstampado = "../recursos/estampado/"+ varEstampado;

                %>
        <div class="card mb-4">
            <div class="card-body">
                <img class="card-img-top position-absolute ml-3" src="<%=imagenEstampado%>" alt="Card image" style="max-width: 80%; max-height: 80%">
                <img class="card-img-top" src="<%=imagenRemera%>" alt="Card image" >
                <div class="card-body">
                    <h5 class="card-title"><%=imagenRemera%></h5>
                    <p class="card-text"><%=varEstampado %> <br> En prenda de color: <%=varColor %></p>
                    <div class="btn-group btn-group-sm">
                        <a href="ElegirTalle.aspx?id=<%=item.ID %>" class="btn btn-primary btn-sm mr-1 my-1"><i class="fas fa-shopping-cart mr-1"></i>Comprar</a>
                        <a class="btn btn-secondary btn-sm mr-1 my-1"><i class="fas fa-info-circle ml-1"></i>Ver Detalle</a>
                    </div>
                </div>
            </div>
        </div>
        <%} %>
    </div>

        <div class="input-group">
        <input type="search" class="form-control rounded" placeholder="Búsqueda por tipo de estampado, prenda, etc." aria-label="search" name="search" id="search" aria-describedby="search-addon" />
        <button type="button" class="btn btn-outline-primary" runat="server" id="button1" >Buscar</button>
    </div>
</asp:Content>
