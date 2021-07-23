<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="TPC_FLORI_PAIS.WebForm1" %>

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
        <form action="/examples/actions/confirmation.php" method="get" onsubmit="return userValid();">
            <h2>Registrarse</h2>
            <p class="hint-text">Crea tu cuenta. Es gratis y solo tomará 1 minuto.</p>
            <div class="form-group">
                <input type="text" class="form-control" name="usuario" placeholder="Usuario" required="required">
            </div>
            <div class="form-group">
                <input type="password" class="form-control" name="contraseña" placeholder="Contraseña" required="required">
            </div>
            <div class="form-group">
                <input type="password" class="form-control" name="confirmar_contraseña" placeholder="Confirmar Contraseña" required="required">
            </div>
            <div class="form-group">
                <div class="row">
                    <div class="col">
                        <input type="text" class="form-control" name="nombre" placeholder="Nombre" required="required">
                    </div>
                    <div class="col">
                        <input type="text" class="form-control" name="apellido" placeholder="Apellido" required="required">
                    </div>
                </div>
            </div>
            <div class="form-group">
                <input type="email" class="form-control" name="email" placeholder="Email" required="required">
            </div>
            <div class="form-group">
                <label class="form-check-label">
                    <input type="checkbox" required="required">
                    Acepto las <a class="text-info" href="#">Condiciones de Uso</a> y las <a class="text-info" href="#">Políticas de Privacidad</a></label>
            </div>
            <div class="form-group">
                <asp:Button ID="registrar" type="submit" class="btn btn-success btn-lg btn-block" runat="server" OnClick="buttonRegistrar_Click" Text="Registrarse ahora!" />
            </div>
        </form>

        <div class="text-center">Ya tienes una cuenta? <a class="text-info" href="Login">Ingresar</a></div>

    </div>

</asp:Content>
