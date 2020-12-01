using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapDatos;
using CapEntidad;
using System.Data;

namespace CapNegocio
{
    public class CNegPacinentes
    {
        CDatPacientes cDatPacientes = new CDatPacientes();

        public bool Guardar_Paciente(CEntidadPacientes cEntidadPacientes) 
        {
            return cDatPacientes.Guardar_Paciente(cEntidadPacientes);
        }

        public bool Anular_Paciente(CEntidadPacientes cEntidadPacientes)
        {
            return cDatPacientes.Anular_Paciente(cEntidadPacientes);
        }

        public DataSet Consultar_Paciente(CEntidadPacientes cEntidadPacientes)
        {
            return cDatPacientes.Consultar_Paciente(cEntidadPacientes);
        }
    }
}
