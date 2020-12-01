<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPacientes.aspx.cs" Inherits="Hospital_1.frmPacientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server" class="was-validated" novalidate>
        <div class="container">
            <div class="card">
                <div class="card-header">
                    <nav aria-label="Page navigation example">
                          <ul class="pagination justify-content-center">
                                <li class="page-item">
                                  <a class="page-link" href="#" aria-label="Previous">
                                    <span aria-hidden="true">&laquo;</span>
                                  </a>
                                </li>
                                <li class="page-item"><a class="page-link" href="frmCitas.aspx">1</a></li>
                                <li class="page-item"><a class="page-link" href="frmPacientes.aspx">2</a></li>
                                <li class="page-item"><a class="page-link" href="frmMedicos.aspx">3</a></li>
                                <li class="page-item">
                                  <a class="page-link" href="#" aria-label="Next">
                                    <span aria-hidden="true">&raquo;</span>
                                  </a>
                                </li>
                          </ul>
                    </nav>

                     <div class="alert alert-primary text-center h4" role="alert">
                         Registro de pacientes.
                    </div>
                </div>

                <div class="card-body">
                    <div class="alert alert-warning text-center" role="alert">
                        <asp:Label ID="lblPac" runat="server" CssClass="lead" Text="Bienvenido al registro de pacientes."></asp:Label>
                    </div>

                     <div class="form-row">
                        <div class="form-group col-md-4">
                          <label for="inputEmail4">Identificacion del paciente</label>
                          <asp:TextBox ID="txtIdPac" CssClass="form-control is-invalid" runat="server" required></asp:TextBox>
                        </div>
                        <div class="form-group col-md-4">
                          <label for="inputPassword4">Tipo de documento</label>
                          
                              <asp:DropDownList ID="tipoDoc" class="form-control" runat="server">
                                <asp:ListItem>Cedula</asp:ListItem>
                                <asp:ListItem>T.I</asp:ListItem>
                                <asp:ListItem>Pasaporte</asp:ListItem>
                            </asp:DropDownList>
                          
                        </div>
                         <div class="form-group col-md-4">
                          <label for="inputPassword4">Nombre del paciente</label>
                          <asp:TextBox ID="txtNomPac" CssClass="form-control is-invalid" runat="server" required></asp:TextBox>
                        </div>
                      </div>

                        <div class="form-row">
                        <div class="form-group col-md-5">
                          <label for="inputEmail4">Direccion del Paciente</label>
                            &nbsp;<asp:TextBox ID="txtDirPac" CssClass="form-control is-invalid" runat="server" required></asp:TextBox>
                            <asp:Label ID="LblNombrePac" runat="server" CssClass="font-italic" Text=""></asp:Label>
                        </div>
                        <div class="form-group col-md-4">
                          <label for="inputPassword4">Telefono del paciente</label>
                          <asp:TextBox ID="txtTelPac" CssClass="form-control is-invalid" runat="server" required></asp:TextBox>
                           <asp:Label ID="lblNombreMed" runat="server" CssClass="font-italic" Text=""></asp:Label>
                        </div>
                         <div class="form-group col-md-3">
                          <label for="inputPassword4">Celular del paciente</label>
                          <asp:TextBox ID="txtCelPac" CssClass="form-control is-invalid" runat="server" required></asp:TextBox>
                        </div>
                      </div>

                        

                    <div class=" text-center">
                        <asp:Button ID="btnConfirmarPac" CssClass="btn btn-outline-success" runat="server" Text="Confirmar" OnClick="btnConfirmarPac_Click"   />
                        <asp:Button ID="btnGuardarPac" CssClass="btn btn-outline-warning" runat="server" Text="Guardar paciente" OnClick="btnGuardarPac_Click"  />
                        <asp:Button ID="btnAnular" CssClass="btn btn-outline-danger" runat="server" Text="Anular paciente" OnClick="btnAnular_Click"  />
                        <asp:Button ID="btnLimpiar" CssClass="btn btn-outline-secondary" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" />

                    </div>
                      
                </div>

            </div>
            
        </div>


    </form>



         <script>
            // Example starter JavaScript for disabling form submissions if there are invalid fields
            (function() {
              'use strict';
              window.addEventListener('load', function() {
                // Fetch all the forms we want to apply custom Bootstrap validation styles to
                var forms = document.getElementsByClassName('needs-validation');
                // Loop over them and prevent submission
                var validation = Array.prototype.filter.call(forms, function(form) {
                  form.addEventListener('submit', function(event) {
                    if (form.checkValidity() === false) {
                      event.preventDefault();
                      event.stopPropagation();
                    }
                    form.classList.add('was-validated');
                  }, false);
                });
              }, false);
            })();
         </script>



<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ho+j7jyWK8fNQe+A12Hb8AhRq26LrZ/JpcUGGOn+Y7RsweNrtN/tE3MoK7ZeZDyx" crossorigin="anonymous"></script>
</body>
</html>
