<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductosPreCargados_Det.aspx.cs" Inherits="TPC_FLORI_PAIS.ABM.ProductosPreCargados.ProductosPreCargados_Det" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>Productos Pre Cargados</h2>
            <ol class="breadcrumb">
                <li>ABM
                </li>
                <li class="active">
                    <strong>Modificar Producto Pre Cargado</strong></li>
            </ol>
        </div>
    </div>
    <div class="wrapper wrapper-content animated fadeInRight">
        <div class="row">
            <div class="col-lg-12">
                <div class="ibox float-e-margins">
                    <div class="ibox-title">
                        <!-- TITULO -->

                        <h5>Modificar Producto Pre Cargado</h5>
                        <span class="pull-right">
                            <!-- BOTONES -->
                            <asp:Button Text="Modificar" runat="server" CssClass="btn btn-primary btn-sm" ID="btn_Modificar" OnClick="btn_Modificar_Click" ValidationGroup="AA" />
                            <asp:Button Text="Eliminar" runat="server" CssClass="btn btn-danger btn-sm" ID="btn_Eliminar" OnClick="btn_Eliminar_Click" ValidationGroup="AA" />
                            <asp:Button Text="Volver" runat="server" CssClass="btn btn-success btn-sm" ID="btn_Volver" OnClick="btn_Volver_Click" />
                        </span>

                        <!-- END TITULO -->
                    </div>
                    <div class="ibox-content">
                        <!-- CONTENIDO -->

                        <div id="Tabs" role="tabpanel">
                            <div class="tab-content">
                                <div id="tab-1" class="tab-pane active" role="tabpanel">
                                    <div class="slimScrollDiv" style="position: relative; overflow: hidden; width: auto; height: 100%;">
                                        <div class="full-height-scroll" style="overflow: hidden; width: auto; height: 100%;">

                                            <div class="row form-horizontal">
                                                <div class="panel-body">
                                                    <asp:DropDownList ID="DropDownListColores" AutoPostBack="true" runat="server"></asp:DropDownList>
                                                    <asp:DropDownList ID="DropDownListCategoria" AutoPostBack="true"  runat="server"></asp:DropDownList>
                                                       <asp:DropDownList ID="DropDownListEstampados"  AutoPostBack="true" runat="server"></asp:DropDownList>
                                                </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    
</asp:Content>
