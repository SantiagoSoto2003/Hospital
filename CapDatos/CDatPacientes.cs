using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapEntidad;
using System.Data;

namespace CapDatos
{
     public class CDatPacientes
    {
        CConexion oConexion = new CConexion();
        SqlCommand ocmd = new SqlCommand();

        public bool Guardar_Paciente(CEntidadPacientes opacientes)
        {
            try 
            {
                ocmd.Connection = oConexion.Conectar("BDHospital");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "sp_guardar_paciente";
                ocmd.Parameters.Add("@pId_paciente", opacientes.Id_paciente1);
                ocmd.Parameters.Add("@ptip_doc", opacientes.Tip_doc);
                ocmd.Parameters.Add("@pnom_paciente", opacientes.Nom_paciente);
                ocmd.Parameters.Add("@pdir_paciente", opacientes.Dir_paciente);
                ocmd.Parameters.Add("@ptel_paciente", opacientes.Tel_paciente);
                ocmd.Parameters.Add("@pcel_paciente", opacientes.Cel_paciente);
                ocmd.ExecuteNonQuery();
                return true;
            
            }
            catch(Exception err) 
            {
                throw new Exception(err.Message);
            }
        }


        public bool Anular_Paciente(CEntidadPacientes opacientes)
        {
            try
            {
                ocmd.Connection = oConexion.Conectar("BDHospital");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "sp_anular_paciente";
                ocmd.Parameters.Add("@pId_paciente", opacientes.Id_paciente1);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception err) 
            {
                throw new Exception(err.Message);
            }

        }


        public DataSet Consultar_Paciente(CEntidadPacientes opacientes)
        {
            try
            {
                ocmd.Connection = oConexion.Conectar("BDHospital");
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.CommandText = "sp_consultar_paciente";
                ocmd.Parameters.Add("@pId_paciente", opacientes.Id_paciente1);
                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;


            }
            catch(Exception err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
