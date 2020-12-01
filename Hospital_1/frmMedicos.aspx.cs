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
    public partial class frmMedicos : System.Web.UI.Page
    {
        CEntidadMedicos cEntidadMedicos = new CEntidadMedicos();
        CNegMedicos cNegMedicos = new CNegMedicos();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtEspMed.Enabled = false;
            txtNomMed.Enabled = false;
            txtTelMed.Enabled = false;

        }

        protected void btnConfirmarMed_Click(object sender, EventArgs e)
        {
            if(txtIdMed.Text == "")
            {
                lblMed.Text = "No hay ninguna identificacion agregada, debes agregar una para continuar con la operacion...";
                lblMed.CssClass = "h5 font-italic text-danger";
                txtIdMed.Focus();
            }
            else
            {
                DataSet ds = new DataSet();
                cEntidadMedicos.Id_medico = txtIdMed.Text;
                ds = cNegMedicos.Consultar_Medico(cEntidadMedicos);
                if(ds.Tables[0].Rows.Count == 0)
                {
                    lblMed.Text = "El codigo esta listo para agregar un medico";
                    lblMed.CssClass = "h5 font-italic";
                    txtNomMed.Focus();
                    txtEspMed.Enabled = true;
                    txtNomMed.Enabled = true;
                    txtTelMed.Enabled = true;
                }
                else
                {
                    lblMed.Text = "Busqueda del medico exitosa";
                    lblMed.CssClass = "h5 font-italic text-success";
                    txtNomMed.Text = ds.Tables[0].Rows[0]["nom_medico"].ToString();
                    txtEspMed.Text = ds.Tables[0].Rows[0]["especialidad"].ToString();
                    txtTelMed.Text = ds.Tables[0].Rows[0]["tel_medico"].ToString();
                }
            }

        }

        protected void btnGuardarMed_Click(object sender, EventArgs e)
        {
            if(txtIdMed.Text != "" && txtEspMed.Text != "" && txtNomMed.Text != "" && txtTelMed.Text != "")
            {
                cEntidadMedicos.Id_medico = txtIdMed.Text;
                cEntidadMedicos.Nom_medico = txtNomMed.Text;
                cEntidadMedicos.Especialidad = txtEspMed.Text;
                cEntidadMedicos.Tel_medico = txtTelMed.Text;

                if (cNegMedicos.Guardar_Medico(cEntidadMedicos))
                {
                    lblMed.Text = "Medico agregado con exito";
                    lblMed.CssClass = "h5 font-italic text-warning";
                }
                else
                {
                    lblMed.Text = "Error al agregar medico";
                    lblMed.CssClass = "h5 font-italic text-danger";
                }
            }
            else
            {
                lblMed.Text = "Error al agregar medico, todos los campos deben estar llenos";
                lblMed.CssClass = "h5 font-italic text-danger";
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblMed.Text = "Bienvenido al registro de medicos";
            lblMed.CssClass = "lead";
            txtIdMed.Text = "";
            txtEspMed.Text = "";
            txtNomMed.Text = "";
            txtTelMed.Text = "";
        }

        protected void btnAnular_Click(object sender, EventArgs e)
        {
            if(txtIdMed.Text == "") 
            {
                lblMed.Text = "Debes agregar una identificacion para continuar con la operacion...";
                lblMed.CssClass = "h5 font-italic text-danger";
                txtIdMed.Focus();
            }
            else
            {
                cEntidadMedicos.Id_medico = txtIdMed.Text;
                if (cNegMedicos.Anular_Medico(cEntidadMedicos))
                {
                    lblMed.Text = "El medico se ha anulado satisfactoriamente";
                    lblMed.CssClass = "h5 font-italic text-danger";
                }
                else
                {
                    lblMed.Text = "Error al agregar el medico";
                    lblMed.CssClass = "h5 font-italic text-danger";
                }
            }
        }
    }
}