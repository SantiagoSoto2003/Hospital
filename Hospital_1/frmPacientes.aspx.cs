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
    public partial class frmPacientes : System.Web.UI.Page
    {
        CEntidadPacientes cEntidadPacientes = new CEntidadPacientes();
        CNegPacinentes cNegPacinentes = new CNegPacinentes();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtCelPac.Enabled = false;
            txtDirPac.Enabled = false;
            txtNomPac.Enabled = false;
            txtTelPac.Enabled = false;

        }

        protected void btnConfirmarPac_Click(object sender, EventArgs e)
        {
            if(txtIdPac.Text == "") 
            {
                lblPac.Text = "No hay ninguna identificacion agregada, debes ingresar una para continuar con la operacion...";
                lblPac.CssClass = "h5 font-italic";
                txtIdPac.Focus();
            }
            else
            {
                DataSet ds = new DataSet();
                cEntidadPacientes.Id_paciente1 = txtIdPac.Text;
                ds = cNegPacinentes.Consultar_Paciente(cEntidadPacientes);

                if(ds.Tables[0].Rows.Count == 0)
                {
                    lblPac.Text = "El codigo esta listo para registrar un paciente";
                    lblPac.CssClass = "h5 font-italic";
                    txtCelPac.Enabled = true;
                    txtDirPac.Enabled = true;
                    txtNomPac.Enabled = true;
                    txtTelPac.Enabled = true;
                    tipoDoc.Focus();
                }
                else
                {
                    lblPac.Text = "Busqueda del paciente exitosa";
                    lblPac.CssClass = "h5 font-italic text-success";
                    txtCelPac.Text = ds.Tables[0].Rows[0]["cel_paciente"].ToString();
                    txtDirPac.Text = ds.Tables[0].Rows[0]["dir_paciente"].ToString();
                    txtNomPac.Text = ds.Tables[0].Rows[0]["nom_paciente"].ToString();
                    txtTelPac.Text = ds.Tables[0].Rows[0]["tel_paciente"].ToString();
                    tipoDoc.Text = ds.Tables[0].Rows[0]["tip_doc"].ToString();
                }
            }
            
        }

        protected void btnGuardarPac_Click(object sender, EventArgs e)
        {
            if(txtIdPac.Text != "" && txtNomPac.Text != "" && txtTelPac.Text != "" && txtDirPac.Text != "" && txtCelPac.Text != "")
            {
                cEntidadPacientes.Id_paciente1 = txtIdPac.Text;
                cEntidadPacientes.Cel_paciente = txtCelPac.Text;
                cEntidadPacientes.Dir_paciente = txtDirPac.Text;
                cEntidadPacientes.Nom_paciente = txtNomPac.Text;
                cEntidadPacientes.Tel_paciente = txtTelPac.Text;
                cEntidadPacientes.Tip_doc = tipoDoc.SelectedValue;

                if (cNegPacinentes.Guardar_Paciente(cEntidadPacientes)) 
                {
                    lblPac.Text = "Paciente agregado con exito";
                    lblPac.CssClass = "h5 font-italic text-warning";
                }
                else
                {
                    lblPac.Text = "Error al agregar el paciente";
                    lblPac.CssClass = "h5-font-italic text-warning";
                }
            }
            else
            {
                lblPac.Text = "Error al agregar el paciente, todos los campos deben estar llenos...";
                lblPac.CssClass = "h5 font-italic text-danger";
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblPac.Text = "Registro de pacientes";
            lblPac.CssClass = "lead";
            txtIdPac.Text = "";
            txtCelPac.Text = "";
            txtDirPac.Text = "";
            txtNomPac.Text = "";
            txtTelPac.Text = "";
        }

        protected void btnAnular_Click(object sender, EventArgs e)
        {
            if(txtIdPac.Text == "")
            {
                lblPac.Text = "Debe ingresar una identificacion para continuar con la operacion...";
                lblPac.CssClass = "h5 font-italic";
                txtIdPac.Focus();
            }
            else
            {
                cEntidadPacientes.Id_paciente1 = txtIdPac.Text;
                if (cNegPacinentes.Anular_Paciente(cEntidadPacientes))
                {
                    lblPac.Text = "El paciente se ha anulado satisfactoriamente...";
                    lblPac.CssClass = "h5 font-italic text-danger";
                }
                else
                {
                    lblPac.Text = "Error al anular el paciente...";
                    lblPac.CssClass = "h5 font-italic text-danger";
                }

            }
        }
    }
}