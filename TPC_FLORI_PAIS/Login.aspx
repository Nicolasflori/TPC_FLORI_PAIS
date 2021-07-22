<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TPC_FLORI_PAIS.WebForm2" %>

<div class="modal-header border-bottom-0">
    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
        <span aria-hidden="true">&times;</span>
    </button>
</div>
<div class="modal-body">
    <div class="form-title text-center">
        <h3>Accedé a tu cuenta</h3>
    </div>
    <div class="d-flex flex-column text-center">
        <div class="form-group">
            <input type="text" class="form-control" id="usuario" placeholder="Usuario...">
        </div>
        <div class="form-group">
            <input type="password" class="form-control" id="password" placeholder="Contraseña...">
        </div>
        <p class="forgotpass"><a target="_blank" href="#a">¿Olvidaste tu contraseña?</a></p>
        <button type="button" class="btn btn-info btn-block btn-round">Ingresar</button>
        <div class="text-center text-muted delimiter">o ingresá usando una red social</div>
        <div class="d-flex justify-content-center social-buttons">
            <button type="button" class="btn btn-secondary btn-round ml-2" data-toggle="tooltip" data-placement="top" title="Twitter">
                <i class="fab fa-twitter"></i>
            </button>
            <button type="button" class="btn btn-secondary btn-round ml-2" data-toggle="tooltip" data-placement="top" title="Facebook">
                <i class="fab fa-facebook"></i>
            </button>
            <button type="button" class="btn btn-secondary btn-round ml-2" data-toggle="tooltip" data-placement="top" title="Linkedin">
                <i class="fab fa-linkedin"></i>
            </button>
        </div>
    </div>
</div>
<div class="modal-footer d-flex justify-content-center">
    <div class="signup-section">¿Todavía no estas registrado? <a href="Registrar" class="text-info">Registrate ahora!</a></div>
</div>

