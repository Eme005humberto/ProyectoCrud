using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CapaDatos
    {
        //Creamos cadena de conexion
        private SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-MEQVVR0;Initial Catalog=DB_EmpresaXYZ;Integrated Security=true");

        //Creamos un metodo que no sirva para conectar el cual tiene como nombre abrir
        public SqlConnection Abrir()
        {
            if(Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }
        //Creamos un metodo que no sirva para conectar el cual tiene como nombre Cerrar
        public SqlConnection Cerrar()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }
    }
}
