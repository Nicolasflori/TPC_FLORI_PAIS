<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="TPC_FLORI_PAIS.Pedidos.Pedidos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../../css/paginadoGrilla.css" rel="stylesheet" />
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <% if (Session["usuario"] != null && ((Dominio.Usuarios)Session["usuario"]).IDPermiso == 1)
        {%>
    <div class="jumbotron mb-3 ">
        <div class="text-black">
            <h1>Pedidos</h1>
        </div>
    </div>
    <%} %>
    <% if (Session["usuario"] != null && ((Dominio.Usuarios)Session["usuario"]).IDPermiso == 2)
        {%>
    <div class="jumbotron mb-3 ">
        <div class="text-black">
            <h1>Mis Compras</h1>
        </div>
    </div>
    <%} %>



    <div class="wrapper wrapper-content animated fadeInRight mb-3">
        <div class="row">
            <div class="col-lg-12">
                <div class="ibox float-e-margins">
                    <div class="ibox-title">
                        <!-- TITULO -->
                        <% if (Session["usuario"] != null && ((Dominio.Usuarios)Session["usuario"]).IDPermiso == 1)
                            {%>
                        <h5>Listado de pedidos a enviar.</h5>
                        <%} %>
                        <% if (Session["usuario"] != null && ((Dominio.Usuarios)Session["usuario"]).IDPermiso == 2)
                            {%>
                        <h5>Listado de compras realizadas.</h5>
                        <%} %>

                        <!-- END TITULO -->
                    </div>
                    <div class="ibox-content">
                    </div>
                    <div class="row form-horizontal">
                        <div class="col-md-12">
                            <div class="table table-responsive">
                                <asp:GridView ID="grid_Pedidos" runat="server" CssClass="table table-responsive table-hover" AutoGenerateColumns="false" GridLines="None"
                                    PageSize="10" Width="100%" AllowPaging="True" OnPageIndexChanging="grid_Pedidos_PageIndexChanging">
                                    <Columns>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:HyperLink NavigateUrl='<%# "Pedidos_Det.aspx?id=" + Eval("ID").ToString() %>' runat="server">
                                                        <span class="fas fa-pencil-alt"></span>
                                                    </asp:HyperLink>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField HeaderText="ID de Compra" DataField="ID" />
                                        <asp:BoundField HeaderText="ID Usuario" DataField="IDUsuario" />
                                        <asp:BoundField HeaderText="Sub Total Productos" DataField="SubTotalProductos" />
                                        <asp:BoundField HeaderText="Costo De Envio" DataField="CostoDeEnvio" />
                                        <asp:BoundField HeaderText="Total" DataField="Total" />
                                        <asp:BoundField HeaderText="Estado" DataField="Estado" />
                                        <asp:BoundField HeaderText="Forma de Pago" DataField="FormaPago" />
                                        <asp:BoundField HeaderText="Fecha" DataField="Fecha" DataFormatString = "{0:dd/MM/yyyy}"/>
                                    </Columns>
                                    <PagerStyle CssClass="pagination-ys" HorizontalAlign="Center" />
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </div>
</asp:Content>

