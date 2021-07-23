<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pedidos_Det.aspx.cs" Inherits="TPC_FLORI_PAIS.Pedidos.Pedidos_Det" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../../css/paginadoGrilla.css" rel="stylesheet" />
    <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>Productos</h2>
        </div>
    </div>

    <div class="wrapper wrapper-content animated fadeInRight">
        <div class="row">
            <div class="col-lg-12">
                <div class="ibox float-e-margins mb-2">
                    <div class="ibox-title">
                        <!-- TITULO -->
                        <h5>Listado de prendas de la compra.</h5>
                        <div class="ibox-tools">
                        </div>
                        <!-- END TITULO -->
                    </div>
                        <% if (Session["usuario"] != null && ((Dominio.Usuarios)Session["usuario"]).IDPermiso == 1)
                    {%>
                    <asp:Button Text="Marcar como Pago" runat="server" CssClass="btn btn-primary btn-sm" ID="btn_Pagar"  ValidationGroup="AA" />
                    <asp:Button Text="Marcar como Enviado" runat="server" CssClass="btn btn-primary btn-sm" ID="btn_Enviado"  ValidationGroup="AA" />
                    <asp:Button Text="Marcar como Entregado" runat="server" CssClass="btn btn-primary btn-sm" ID="btn_Entregado"  ValidationGroup="AA" />
                    <%} %>
                    <div class="ibox-content">
                        <div class="row form-horizontal">
                            <div class="col-md-12">
                                <div class="table table-responsive">
                                    <asp:GridView ID="grid_Productos" runat="server" CssClass="table table-responsive table-hover" AutoGenerateColumns="false" GridLines="None" OnPageIndexChanging="grid_Productos_PageIndexChanging"
                                        PageSize="10" Width="100%" AllowPaging="True">
                                        <Columns>
                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                    <!--<asp:HyperLink NavigateUrl='<%# "Pedidos_Det.aspx?id=" + Eval("ID").ToString() %>' runat="server">
                                                        <span class="fas fa-pencil-alt"></span>
                                                    </asp:HyperLink>-->
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField HeaderText="IDEstampado" DataField="IDEstampado" />
                                            <asp:BoundField HeaderText="IDColor" DataField="IDColor" />
                                            <asp:BoundField HeaderText="IDCategoria" DataField="IDCategoria" />
                                            <asp:BoundField HeaderText="IDTalle" DataField="IDTalle" />
                                            <asp:BoundField HeaderText="Precio" DataField="Precio" />
                                            <asp:BoundField HeaderText="Cantidad" DataField="Cantidad" />
                                            <asp:BoundField HeaderText="PrecioxProducto" DataField="PrecioxProducto" />
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
