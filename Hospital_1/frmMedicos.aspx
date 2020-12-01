<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMedicos.aspx.cs" Inherits="Hospital_1.frmMedicos" %>

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
                         Registro de medicos.
                    </div>
                </div>

                <div class="card-body">
                    <div class="alert alert-warning text-center" role="alert">
                        <asp:Label ID="lblMed" runat="server" CssClass="lead" Text="Bienvenido al registro de medicos."></asp:Label>
                    </div>

                     <div class="form-row">
                        <div class="form-group col-md-6">
                          <label for="inputEmail4">Identificacion del medico</label>
                          <asp:TextBox ID="txtIdMed" CssClass="form-control is-invalid" runat="server" required></asp:TextBox>
                        </div>
                        
                         <div class="form-group col-md-6">
                          <label for="inputPassword4">Nombre del medico</label>
                          <asp:TextBox ID="txtNomMed" CssClass="form-control is-invalid" runat="server" required></asp:TextBox>
                        </div>
                      </div>

                        <div class="form-row">
                        <div class="form-group col-md-6">
                          <label for="inputEmail4">Especialidad del medico</label>
                            &nbsp;<asp:TextBox ID="txtEspMed" CssClass="form-control is-invalid" runat="server" required></asp:TextBox>
                            <asp:Label ID="LblNombrePac" runat="server" CssClass="font-italic" Text=""></asp:Label>
                        </div>
                        <div class="form-group col-md-6">
                          <label for="inputPassword4">Telefono del medico</label>
                          <asp:TextBox ID="txtTelMed" CssClass="form-control is-invalid" runat="server" required></asp:TextBox>
                           <asp:Label ID="lblNombreMed" runat="server" CssClass="font-italic" Text=""></asp:Label>
                        </div>
                        </div>

                        

                    <div class=" text-center">
                        <asp:Button ID="btnConfirmarMed" CssClass="btn btn-outline-success" runat="server" Text="Confirmar" OnClick="btnConfirmarMed_Click"    />
                        <asp:Button ID="btnGuardarMed" CssClass="btn btn-outline-warning" runat="server" Text="Guardar medico" OnClick="btnGuardarMed_Click"  />
                        <asp:Button ID="btnAnular" CssClass="btn btn-outline-danger" runat="server" Text="Anular medico" OnClick="btnAnular_Click"   />
                        <asp:Button ID="btnLimpiar" CssClass="btn btn-outline-secondary" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click"  />

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
