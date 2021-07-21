<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductosPreCargados_New.aspx.cs" Inherits="TPC_FLORI_PAIS.ABM.ProductosPreCargados.ProductosPreCargados_New" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>Productos Pre Cargados</h2>
            <ol class="breadcrumb">
                <li>ABM
                </li>
                <li class="active">
                    <strong>Agregar Producto Pre Cargado</strong></li>
            </ol>
        </div>
    </div>

    <div class="wrapper wrapper-content animated fadeInRight">
        <div class="row">
            <div class="col-lg-12">
                <div class="ibox float-e-margins">
                    <div class="ibox-title">
                        <!-- TITULO -->

                        <h5>Agregar Producto Pre Cargado</h5>
                        <span class="pull-right">
                            <!-- BOTONES -->
                            <asp:Button Text="Agregar" runat="server" CssClass="btn btn-primary btn-sm" ID="btn_Agregar" OnClick="btn_Agregar_Click" ValidationGroup="AA" />
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
                                                 <asp:DropDownList ID="DropDownListColores" runat="server"></asp:DropDownList>
                                                    <asp:DropDownList ID="DropDownListCategoria" runat="server"></asp:DropDownList>
                                                       <asp:DropDownList ID="DropDownListEstampados" runat="server"></asp:DropDownList>
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
