<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ABMColores.aspx.cs" Inherits="TPC_FLORI_PAIS.ABMColores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Colores</h1>
    <asp:Button ID="Agregar" runat="server" OnClick="Agregar_Click" Text="Agregar" />
    <asp:GridView ID="GridViewColores" AutoGenerateColumns="false" runat="server">
     <Columns>
        <asp:BoundField DataField="ID" HeaderText="ID" />
        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" /> 
         <asp:TemplateField>
          <ItemTemplate>
           <asp:Button ID="Modificar" runat="server" OnClick="Modificar_Click" CommandArgument="<%=GridViewColores.DataSource %>" Text="Modificar" />
          </ItemTemplate>
         </asp:TemplateField> 
         <asp:TemplateField>
          <ItemTemplate>
           <asp:Button ID="Eliminar" runat="server" Text="Eliminar" />
          </ItemTemplate>
         </asp:TemplateField>
      </Columns>
    </asp:GridView>
   <div runat="server" id="theDiv" visible="false">
       <h5>Agregar Color</h5>
      <div class="form-group">
                <input type="text" class="form-control" name="descripcion" placeholder="descripcion" required="required">
            </div>
       <asp:Button ID="Aceptar" runat="server"  OnClick="Aceptar_Click" Text="Agregar" />
   </div>            
               
   
</asp:Content>
