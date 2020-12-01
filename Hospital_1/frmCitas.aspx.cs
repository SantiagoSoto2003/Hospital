using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapEntidad;
using CapNegocio;
using System.Data;


namespace Hospital_1
{
    public partial class frmCitas : System.Web.UI.Page
    {
        CNegCitas oNegCitas = new CNegCitas();
        CNegPacinentes cNegPacientes = new CNegPacinentes();
        CNegMedicos cNegMedicos = new CNegMedicos();
        CEntidadCitas oCEntidadCitas = new CEntidadCitas();
        CEntidadPacientes cEntidadPacientes = new CEntidadPacientes();
        CEntidadMedicos cEntidadMedicos = new CEntidadMedicos();
        protected void Page_Load(object sender, EventArgs e)
        {
            
                txtFechaCita.Enabled = false;
                txtHoraCita.Enabled = false;
                txtCodPaciente.Enabled = false;
                txtCodMedico.Enabled = false;
                txtVlrConsulta.Enabled = false;
                txtDiagnostico.Enabled = false;
                txtAcompañante.Enabled = false;               
           

        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(txtCodCita.Text == "") 
            {
                lblCita.Text = "No hay ningun codigo agregado, debes agregar uno para ejecutar la operacion...";
                lblCita.CssClass = "h5 font-italic text-danger";
                txtCodCita.Focus();
            }
            else
            {
                DataSet ds = new DataSet();
                oCEntidadCitas.Cod_cita = txtCodCita.Text;
                ds = oNegCitas.Consultar_Cita(oCEntidadCitas);

                if (ds.Tables[0].Rows.Count == 0) 
                {
                    lblCita.Text = "El codigo esta listo para agregar una cita.";
                    lblCita.CssClass = "h5 font-italic";
                    txtFechaCita.Enabled = true;
                    txtHoraCita.Enabled = true;
                    txtCodPaciente.Enabled = true;
                    txtCodMedico.Enabled = true;
                    txtVlrConsulta.Enabled = true;
                    txtDiagnostico.Enabled = true;
                    txtAcompañante.Enabled = true;
                    btnBuscarMed.Enabled = true;
                    btnBuscarPac.Enabled = true;
                    btnGuardarCita.Enabled = true;
                    txtFechaCita.Focus();
                }
                else
                {
                    lblCita.Text = "Busqueda de la cita exitosa";
                    lblCita.CssClass = "h5 font-italic text-success";
                    txtFechaCita.Text = ds.Tables[0].Rows[0]["fecha"].ToString();
                    txtHoraCita.Text = ds.Tables[0].Rows[0]["hora"].ToString();
                    txtCodPaciente.Text = ds.Tables[0].Rows[0]["Id_paciente"].ToString();
                    txtCodMedico.Text = ds.Tables[0].Rows[0]["id_medico"].ToString();
                    txtVlrConsulta.Text = ds.Tables[0].Rows[0]["valor"].ToString();
                    txtDiagnostico.Text = ds.Tables[0].Rows[0]["diagnostico"].ToString();
                    txtAcompañante.Text = ds.Tables[0].Rows[0]["Nom_acompanante"].ToString();
                    txtFechaCita.Enabled = false;
                    txtHoraCita.Enabled = false;
                    txtCodPaciente.Enabled = false;
                    txtCodMedico.Enabled = false;
                    txtVlrConsulta.Enabled = false;
                    txtDiagnostico.Enabled = false;
                    txtAcompañante.Enabled = false;
                    btnBuscarMed.Enabled = true;
                    btnBuscarPac.Enabled = true;
                    btnGuardarCita.Enabled = true;
                }
            }
        }

        protected void btnGuardarCita_Click(object sender, EventArgs e)
        {
            if (txtCodCita.Text != "" && txtFechaCita.Text != "" && txtHoraCita.Text != "" && txtCodPaciente.Text != "" && txtCodMedico.Text != "" && txtVlrConsulta.Text != "" && txtDiagnostico.Text != "" && txtAcompañante.Text != "") 
            {
                oCEntidadCitas.Cod_cita = txtCodCita.Text;
                oCEntidadCitas.Fecha = Convert.ToDateTime(txtFechaCita.Text);
                oCEntidadCitas.Hora = Convert.ToDateTime(txtHoraCita.Text);
                oCEntidadCitas.Id_paciente1 = txtCodPaciente.Text;
                oCEntidadCitas.Id_medico = txtCodMedico.Text;
                oCEntidadCitas.Valor = Convert.ToInt32(txtVlrConsulta.Text);
                oCEntidadCitas.Diagnostico = txtDiagnostico.Text;
                oCEntidadCitas.Nom_acompanante1 = txtAcompañante.Text;

                if (oNegCitas.Guardar_Cita(oCEntidadCitas))
                {
                    lblCita.Text = "Registro agregado con exito";
                    lblCita.CssClass = "h5 font-italic text-warning";
                }
                else 
                {
                    lblCita.Text = "Error al agregar el registro";
                    lblCita.CssClass = "h5 font-italic text-danger";
                }
            }
            else 
            {
                lblCita.Text = "Error al agregar la cita, todos los campos deben estar llenos...";
                lblCita.CssClass = "h5 font-italic text-danger";
            }
            

        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodCita.Text = "";
            txtFechaCita.Text = "";
            txtHoraCita.Text = "";
            txtCodPaciente.Text = "";
            txtCodMedico.Text = "";
            txtVlrConsulta.Text = "";
            txtDiagnostico.Text = "";
            txtAcompañante.Text = "";
            lblNombreMed.Text = "";
            LblNombrePac.Text = "";
            lblCita.Text = "Bienvenido a la asignacion de la cita.";
            lblCita.CssClass = "lead";
        }

        protected void btnBuscarPac_Click(object sender, EventArgs e)
        {
            if(txtCodPaciente.Text == "")
            {
                LblNombrePac.Text = "Debe ingresar el codigo del paciente para ejecutar la operacion...";
                LblNombrePac.CssClass = "h5 font-italic text-danger";
                txtCodPaciente.Focus();
            }
            else
            {
                DataSet ds = new DataSet();
                cEntidadPacientes.Id_paciente1 = txtCodPaciente.Text;
                ds = cNegPacientes.Consultar_Paciente(cEntidadPacientes);

                if(ds.Tables[0].Rows.Count == 0) 
                {
                    LblNombrePac.Text = "No existe paciente relacionado con ese codigo...";
                    LblNombrePac.CssClass = "h5 font-italic text-primary";
                }
                else 
                {
                    lblCita.Text = "Busqueda del paciente exitosa";
                    lblCita.CssClass = "h5 font-italic text-primary";
                    LblNombrePac.Text = ds.Tables[0].Rows[0]["nom_paciente"].ToString();
                
                }
            }
        }

        protected void btnBuscarMed_Click(object sender, EventArgs e)
        {
            if(txtCodMedico.Text == "")
            {
                lblNombreMed.Text = "Debes ingresar el codigo del medico para realizar la operacion...";
                lblNombreMed.CssClass = "h5 font-italic";
                txtCodMedico.Focus();
            }
            else
            {
                DataSet ds = new DataSet();
                cEntidadMedicos.Id_medico = txtCodMedico.Text;
                ds = cNegMedicos.Consultar_Medico(cEntidadMedicos);

                if(ds.Tables[0].Rows.Count == 0)
                {
                    lblNombreMed.Text = "No existe medico relacionado con el codigo...";
                    lblNombreMed.CssClass = "h5 font-italic text-danger";
                }
                else
                {
                    lblCita.Text = "Busqueda del medico exitosa";
                    lblCita.CssClass = "h5 font-italic text-white bg-dark";
                    lblNombreMed.Text = ds.Tables[0].Rows[0]["nom_medico"].ToString();
                }
            }
        }

        protected void btnAnular_Click(object sender, EventArgs e)
        {
            if(txtCodCita.Text == "")
            {
                lblCita.Text = "Debes agregar un codigo para anular una cita...";
                lblCita.CssClass = "h5 font-italic text-danger";
                txtCodCita.Focus();
            }
            else
            {
                oCEntidadCitas.Cod_cita = txtCodCita.Text;
                if (oNegCitas.Anular_Cita(oCEntidadCitas)) 
                {
                    lblCita.Text = "La cita se ha anulado satisfactoriamente...";
                    lblCita.CssClass = "h5 font-italic text-danger";
                }
                else
                {
                    lblCita.Text = "Error al anular la cita...";
                    lblCita.CssClass = "h5 font-italic text-danger";
                }
            }
        }
    }
}