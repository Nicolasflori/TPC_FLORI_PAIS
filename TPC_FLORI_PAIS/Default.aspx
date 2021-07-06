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


    <div class="row">
        <% foreach (Dominio.ProductoPreCargado item in listaProductoPreCargado)
            {%>
        <div class="card-deck">
            <div class="card">
                <img class="card-img-top" src="https://http2.mlstatic.com/D_NQ_NP_787464-MLA31562482896_072019-O.jpg" alt="Card image cap">
                <div class="card-body">
                    <h5 class="card-title"><%= item.IDColor%></h5>
                    <p class="card-text">Black Sabbath - Master of Reality</p>
                </div>
            </div>
        </div>
        <%} %>
    </div>
</asp:Content>
