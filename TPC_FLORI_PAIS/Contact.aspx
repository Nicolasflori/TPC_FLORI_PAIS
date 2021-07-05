<%@ Page Title="Contacto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="TPC_PAIS_FLORI.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br></br>
    <h2><%: Title %>.</h2>
    <br></br>
    <h3>Si tiene alguna duda en especial puede enviarnos un mail.</h3>
      <div class="contact_body">
        <form action="mailto:nicolasflori@hotmail.com" method="post" enctype="text/plain"><br/>
          Tu Nombre:<br />
          <input type="text" name="name" size="78" /><br/><br/>
          E-mail:<br />
          <input type="text" name="mail" size="78" /><br/><br/>
          Comentarios:<br />
          <textarea name="email" id="email" cols="80" rows="10"></textarea
          ><br /><br />
          <input type="submit" value="Enviar " />
          <input type="reset" value="Resetear" />
        </form>
      </div>
</asp:Content>
