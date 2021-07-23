﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="TPC_FLORI_PAIS.Pedidos.Pedidos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../../css/paginadoGrilla.css" rel="stylesheet" />
    <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>Pedidos</h2>
        </div>
    </div>

    <div class="wrapper wrapper-content animated fadeInRight">
        <div class="row">
            <div class="col-lg-12">
                <div class="ibox float-e-margins">
                    <div class="ibox-title">
                        <!-- TITULO -->
                        <h5>Pedidos</h5>
                        <div class="ibox-tools">
                            <a class="collapse-link">
                                <i class="fa fa-chevron-up"></i>
                            </a>
                        </div>
                        <!-- END TITULO -->
                    </div>
                    <div class="ibox-content">
                        <!-- CONTENIDO -->
                        <div class="row form-horizontal">
                            <div class="col-md-8 form-group">
                                <label class="col-md-2 control-label">
                                    Filtrar
                                </label>
                                <div class="col-md-10">
                                    <asp:TextBox runat="server" ID="txt_Buscar" CssClass="form-control" placeholder="Codigo, descripción o familia" />
                                </div>
                            </div>
                            <div class="col-md-4  form-group">
                                <div class="col-md-12">
                                    <asp:Button Text="Buscar" ID="btn_Buscar" runat="server" CssClass="btn btn-primary" OnClick="btn_Buscar_Click" />
                                </div>
                            </div>
                        </div>
                        <div class="row form-horizontal">
                            <div class="col-md-12">
                                <div class="table table-responsive">
                                    <asp:GridView ID="grid_Pedidos" runat="server" CssClass="table table-responsive table-hover" AutoGenerateColumns="false" GridLines="None"
                                        PageSize="10" Width="100%" AllowPaging="True" OnPageIndexChanging="grid_Pedidos_PageIndexChanging">
                                        <Columns>
                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                    <!--<asp:HyperLink NavigateUrl='<%# "Pedidos_Det.aspx?id=" + Eval("ID").ToString() %>' runat="server">
                                                        <span class="fas fa-pencil-alt"></span>
                                                    </asp:HyperLink>-->
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField HeaderText="ID de Compra" DataField="ID" />
                                            <asp:BoundField HeaderText="ID Usuario" DataField="IDUsuario" />
                                            <asp:BoundField HeaderText="Sub Total Productos" DataField="SubTotalProductos" />
                                            <asp:BoundField HeaderText="Costo De Envio" DataField="CostoDeEnvio" />
                                            <asp:BoundField HeaderText="Total" DataField="Total" />
                                            <asp:BoundField HeaderText="Estado" DataField="Estado" />
                                            <asp:BoundField HeaderText="Forma de Pago" DataField="FormaPago" />
                                            <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
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
    <section class="row wrapper wrapper-content">
        <div style="width: 100%; height: 400px; overflow: scroll">
            <asp:GridView runat="server" ID="GridView1" CssClass="table table-responsive table-hover" GridLines="None" AutoGenerateColumns="True"></asp:GridView>
        </div>
    </section>
</asp:Content>

