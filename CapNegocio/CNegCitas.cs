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
    public class CNegCitas
    {
        CDatCitas odatcitas = new CDatCitas();

        public bool Guardar_Cita(CEntidadCitas oentcitas)
        {
            return odatcitas.Guardar_Cita(oentcitas);
            
        }

        public bool Anular_Cita(CEntidadCitas oentcitas)
        {
            return odatcitas.Anular_Cita(oentcitas);

        }
        public DataSet Consultar_Cita(CEntidadCitas oentcitas)
        {
            return odatcitas.Consultar_Cita(oentcitas);

        }

    }
}
