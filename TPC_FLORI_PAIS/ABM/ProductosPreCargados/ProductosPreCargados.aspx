<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductosPreCargados.aspx.cs" Inherits="TPC_FLORI_PAIS.ABM.ProductosPreCargados.ProductosPreCargados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <link href="../../css/paginadoGrilla.css" rel="stylesheet" />

    <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>Productos Pre Cargados</h2>
            <ol class="breadcrumb">
                <li>
                    ABM
                </li>
                <li class="active">
                    <strong>Productos Pre Cargados</strong></li>
            </ol>
        </div>
       </div>

    <div class="wrapper wrapper-content animated fadeInRight">
        <div class="row">
            <div class="col-lg-12">
                <div class="ibox float-e-margins">
                    <div class="ibox-title">
                        <!-- TITULO -->

                        <h5>Productos Pre Cargados</h5>
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
                            <div class="col-md-4  form-group">
                                <div class="col-md-12">
                                    <asp:Button Text="Agregar" ID="btn_Agregar" runat="server" CssClass="btn btn-primary" OnClick="btn_Agregar_Click" />
                                </div>
                            </div>

                        </div>

                        <div class="row form-horizontal">

                            <div class="col-md-12">

                                <div class="table table-responsive">

                                    <asp:GridView ID="grid_ProductosPreCargados" runat="server" CssClass="table table-responsive table-hover" AutoGenerateColumns="false" GridLines="None"
                                         PageSize="10" Width="100%" AllowPaging="True" OnPageIndexChanging="grid_ProductosPreCargados_PageIndexChanging" OnRowDataBound="grid_ProductosPreCargados_RowDataBound">
                                        <Columns>
                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                    <asp:HyperLink NavigateUrl='<%# "Estampados_Det.aspx?id=" + Eval("ID").ToString() %>' runat="server">
                                                        <span class="fas fa-pencil-alt"></span>
                                                    </asp:HyperLink>
                                                </ItemTemplate>
                                            </asp:TemplateField>
					                         <asp:BoundField HeaderText="IDColor" DataField="IDColor"  />
                                            <asp:BoundField HeaderText="IDCategoria" DataField="IDCategoria" />
                                            <asp:BoundField HeaderText="IDEstampado" DataField="IDEstampado" />
                                            <asp:BoundField HeaderText="FechaCarga" DataField="FechaCarga" />
                                        </Columns>
                                        <PagerStyle CssClass="pagination-ys" HorizontalAlign="Center"/>
                                    </asp:GridView>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    
    
    <section  class="row wrapper wrapper-content">
        <div style="width: 100%; height: 400px; overflow: scroll">
            <asp:GridView runat="server" ID="GridView1" CssClass="table table-responsive table-hover" GridLines="None" AutoGenerateColumns="True" ></asp:GridView>
        </div>
</asp:Content>
