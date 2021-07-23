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
                        <input type="text" class="form-control" name="nombre" placeholder="Nombre">
                    </div>
                    <div class="col">
                        <input type="text" class="form-control" name="apellido" placeholder="Apellido">
                    </div>
                </div>
            </div>
            <div class="form-group">
                <input type="email" class="form-control" name="email" placeholder="Email">
            </div>
            <div class="form-group">
                <input type="text" class="form-control" name="dni" placeholder="DNI">
            </div>
            <div class="form-group">
                <input type="text" class="form-control" name="telefono" placeholder="Teléfono">
            </div>
            <h2>Dirección</h2>
            <div class="form-group">
                <input type="text" class="form-control" name="ciudad" placeholder="Ciudad">
            </div>
            <div class="form-group">
                <input type="text" class="form-control" name="provincia" placeholder="Provincia">
            </div>
            <div class="form-group">
                <input type="text" class="form-control" name="calle" placeholder="Calle">
            </div>
            <div class="form-group">
                <input type="text" class="form-control" name="numeracion" placeholder="Numeración">
            </div>
            <div class="form-group">
                <input type="text" class="form-control" name="piso" placeholder="Piso">
            </div>
            <div class="form-group">
                <input type="text" class="form-control" name="depto" placeholder="Depto">
            </div>
            <div class="form-group">
                <input type="text" class="form-control" name="cp" placeholder="Código Postal">
            </div>

            <div class="form-group">
                <asp:Button type="submit" class="btn btn-success btn-lg btn-block" runat="server" OnClick="buttonGuardar_Click" Text="Guardar" />
            </div>
        </form>
    </div>

</asp:Content>
