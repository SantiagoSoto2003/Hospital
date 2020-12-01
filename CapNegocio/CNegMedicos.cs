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
    public class CNegMedicos
    {
        CDatMedicos CDatMedicos = new CDatMedicos();

        public bool Guardar_Medico(CEntidadMedicos cEntidadMedicos) 
        {
            return CDatMedicos.Guardar_Medico(cEntidadMedicos);
        }

        public bool Anular_Medico(CEntidadMedicos cEntidadMedicos) 
        {
            return CDatMedicos.Anular_Medico(cEntidadMedicos);
        }

        public DataSet Consultar_Medico(CEntidadMedicos cEntidadMedicos)
        {
            return CDatMedicos.Consultar_Medico(cEntidadMedicos);
        }
    }
}
