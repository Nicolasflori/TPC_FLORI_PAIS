<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ComoComprar.aspx.cs" Inherits="TPC_PAIS_FLORI.ComoComprar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <h2><%: Title %></h2>
    <h2>Cómo Comprar</h2>
    <br>
    <br />

    <p>Agregue las remeras que desee comprar al carrito con el botón Comprar, y luego de elegir talle y cantidad, agregar al carrito.</p>
    <p>También puede agregar al carrito la remera que usted diseñe en la pestaña "Diseñe su propia remera".</p>
    <p>Con el botón de comprar carrito podrá comprar las remeras seleccionadas, completando el pago en la siguiente pantalla.</p>
    <p>Se aceptan tarjetas de credito y debito, ademas de transferencias bancarias y pago con MercadoPago.</p>
    <br>
    <br />
    <h5>Esperamos tu compra!</h5>
    <br>
    <br />
    <asp:Image ID="imgImagen" runat="server" ImageUrl="https://static.wixstatic.com/media/5854b3_e44134231a6b4d2da54937957554f1d5~mv2.jpg/v1/fill/w_980,h_155,al_c,q_80,usm_0.66_1.00_0.01/pagina_JPG.webp" AlternateText="kyocode" />

</asp:Content>
