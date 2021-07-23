<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cuenta.aspx.cs" Inherits="TPC_FLORI_PAIS.WebForm3" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <head>
        <meta charset="utf-8">
        <link href="StyleSheet2.css" rel="stylesheet" type="text/css" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
        <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Roboto:400,700">
        <title>Bootstrap Simple Registration Form</title>
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
        <script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
        <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>
    </head>

    <div class="signup-form">
        <form action="/examples/actions/confirmation.php" method="post">
            <h2>Mi Cuenta</h2>
            <p class="hint-text">Actualice sus datos y clickee en Guardar.</p>
            <div class="form-group">
                <div class="row">
                    <div class="col">
                        <asp:TextBox runat="server" class="form-control" name="nombre" placeholder="Nombre" id="txtnombre"/>
                        <asp:RequiredFieldValidator runat="server" id="val" controltovalidate="txtnombre" errormessage="Ingrese un Nombre!" ForeColor="Red"/>
                    </div>
                    <div class="col">
                        <asp:TextBox runat="server" class="form-control" name="apellido" placeholder="Apellido" id="txtapellido" />  
                        <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator1" controltovalidate="txtapellido" errormessage="Ingrese un Apellido!" ForeColor="Red"/>
                    </div>
                </div>
            </div>
            <div class="form-group">
                <asp:TextBox runat="server" class="form-control" name="email" placeholder="Email" id="txtemail" />  
                <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator2" controltovalidate="txtemail" errormessage="Ingrese un Email!" ForeColor="Red"/>
            </div>
            <div class="form-group">
                <asp:TextBox runat="server" class="form-control" name="dni" placeholder="DNI" id="txtdni" />
                <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator3" controltovalidate="txtdni" errormessage="Ingrese un DNI!" ForeColor="Red"/>
            </div>
            <div class="form-group">
                <asp:TextBox runat="server" class="form-control" name="telefono" placeholder="Teléfono" id="txttelefono" />
                <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator4" controltovalidate="txttelefono" errormessage="Ingrese un Telefono!" ForeColor="Red"/>
            </div>
            <h2>Dirección</h2>
            <div class="form-group">
                <asp:TextBox runat="server" class="form-control" name="ciudad" placeholder="Ciudad" id="txtciudad" />
                <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator5" controltovalidate="txtciudad" errormessage="Ingrese una Ciudad!" ForeColor="Red" />
            </div>
            <div class="form-group">
                <asp:TextBox runat="server" class="form-control" name="provincia" placeholder="Provincia" id="txtprovincia" />  
                <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator6" controltovalidate="txtprovincia" errormessage="Ingrese una Provincia!" ForeColor="Red"/>
            </div>
            <div class="form-group">
                <asp:TextBox runat="server" class="form-control" name="calle" placeholder="Calle" id="txtcalle" />  
                <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator7" controltovalidate="txtcalle" errormessage="Ingrese una Calle!" ForeColor="Red"/>
            </div>
            <div class="form-group">
                <asp:TextBox runat="server" class="form-control" name="numeracion" placeholder="Numeración" id="txtnumeracion" />  
                <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator8" controltovalidate="txtnumeracion" errormessage="Ingrese una Numeracion!" ForeColor="Red"/>
            </div>
            <div class="form-group">
                <asp:TextBox runat="server" class="form-control" name="piso" placeholder="Piso" id="txtpiso" />  
            </div>
            <div class="form-group">
                <asp:TextBox runat="server" class="form-control" name="depto" placeholder="Depto" id="txtdepto" />  
            </div>
            <div class="form-group">
                <asp:TextBox runat="server" class="form-control" name="cp" placeholder="Código Postal" id="txtcp" />  
                <asp:RequiredFieldValidator runat="server" id="RequiredFieldValidator9" controltovalidate="txtcp" errormessage="Ingrese un Codigo Postal!" ForeColor="Red"/>
            </div>

            <div class="form-group">
                <asp:Button type="submit" class="btn btn-success btn-lg btn-block" runat="server" OnClick="buttonGuardar_Click" Text="Guardar" />
            </div>
        </form>
    </div>

</asp:Content>
