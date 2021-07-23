<%@ Page Title="Contacto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="TPC_PAIS_FLORI.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <h2 class="mb-2"><%: Title %> </h2>
    <h4 class="mb-3">Si tenes alguna duda en especial, mandanos un mail</h4>
    <p>Te responderemos lo antes posible!</p>
      <div class="contact_body">
          Asunto:<br />
            <asp:TextBox runat="server" ID="txtAsunto" CssClass="form-control" Font-Size="Large" required/>
          E-mail:<br />
            <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" Font-Size="Large" required/>
          Comentarios:<br />
            <asp:TextBox runat="server" ID="txtCuerpo" CssClass="form-control" Font-Size="Large" TextMode="MultiLine" Rows="5" required/>
          <br /><br />
            <asp:Button Text="Enviar" runat="server" class="btn btn-primary" OnClick="btnEnviar" ID="buttonEnviar"/> 
            <asp:Button Text="Resetear" runat="server" class="btn btn-secondary" OnClick="btnReset" ID="buttonReset"/>
      </div>
</asp:Content>
