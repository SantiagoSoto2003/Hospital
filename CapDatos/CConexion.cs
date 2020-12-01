using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDatos
{
    class CConexion
    {
        public SqlConnection Conectar(string Cnx)
        {
            try 
            {
                SqlConnection oConectar = new SqlConnection(ConfigurationSettings.AppSettings[Cnx].ToString());
                oConectar.Open();
                return oConectar;            
            }
            catch(Exception err) 
            {
                throw new Exception(err.Message);
            }
        
        
        }
    }
}
