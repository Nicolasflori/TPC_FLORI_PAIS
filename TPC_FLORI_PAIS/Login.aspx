<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TPC_FLORI_PAIS.WebForm2" %>

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
            <h2>Acceder</h2>
            <p class="hint-text">A continuación ingrese su Usuario y Contraseña.</p>
            <div class="form-group">
                <input type="text" class="form-control" name="usuario" placeholder="Usuario" required="required">
            </div>
            <div class="form-group">
                <input type="password" class="form-control" name="contraseña" placeholder="Contraseña" required="required">
            </div>
            <div class="form-group">
                <asp:Button type="submit" class="btn btn-success btn-lg btn-block" runat="server" OnClick="buttonIngresar_Click" Text="Ingresar" />
            </div>
        </form>

        <div class="text-center">Olvidaste tu contraseña? <a class="text-info li-modal" href="">Recuperar Contraseña</a></div>

    </div>

</asp:Content>