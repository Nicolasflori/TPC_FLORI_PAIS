﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ElegirTalle.aspx.cs" Inherits="TPC_FLORI_PAIS.ElegirTalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Continuar con la Compra</h1>

    <asp:Image ID="Imagen" runat="server" />
     <div class="card-body">
        <h5><asp:Label ID="lblCategoria" runat="server" Text="Label" Font-Size="30px"></asp:Label></h5>
        <p>Descripción: <asp:Label ID="LblEstampado" runat="server" Text="Label" Font-Size="20px"></asp:Label></p>
        <h6 class="mb-2">Precio: $<span><asp:Label ID="LblPrecio" runat="server" Text="Label" Font-Size="15px"></asp:Label></span></h6>
        <p class="card-text"><small class="text-muted"></small></p>
       <%-- <button class="btn btn-secondary" runat="server" onserverclick="Unnamed_ServerClick"> Volver atrás</button>--%>
    </div>


</asp:Content>