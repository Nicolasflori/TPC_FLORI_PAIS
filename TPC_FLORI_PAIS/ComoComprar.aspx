<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ComoComprar.aspx.cs" Inherits="TPC_PAIS_FLORI.ComoComprar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <h2><%: Title %></h2>
    <h1>Cómo Comprar</h1>
    <p>Agregue las remeras que desee comprar al carrito con el botón agregar al carrito.</p>
    <p>También puede agregar al carrito la remera que usted diseñe en la pestaña "Diseñe su propia remera".</p>
    <p>Con el botón de comprar carrito podrá comprar las remeras seleccionadas, completando los datos del envío y de pago.</p>
    <p>Se aceptan tarjetas de credito y debito, ademas de transferencias bancarias y pago con MercadoPago.</p>
</asp:Content>
