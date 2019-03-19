using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class conexion
    {
        private String cadenaConexionBaseDeDatos;
        public String obtenerCadenaDeConexion()
        {
            //aqui se encuentra la cadena de conexion
            cadenaConexionBaseDeDatos = "Data Source = DESKTOP; Initial Catalog = Conchas_la_5; Integrated Security = True";
            return cadenaConexionBaseDeDatos;
        }


        public SqlConnection conexionBaseDatos;
        public conexion()
        {
            conexionBaseDatos = new SqlConnection(obtenerCadenaDeConexion());
        }

        public SqlConnection openDataBase()
        {
            conexionBaseDatos.Open();
            if (conexionBaseDatos == null)
            {
                conexionBaseDatos.Close();
            }
            return conexionBaseDatos;
        }

        /// <summary>
        /// Metodo encargado de Cerrar la conexion si esta Abierta.
        /// </summary>
        public void closeDatabase()
        {
            try
            {
                conexionBaseDatos.Close();
            }
            catch (Exception _ex)
            {
                String mnsaje = _ex.Message;
            }
        }


    }
}
