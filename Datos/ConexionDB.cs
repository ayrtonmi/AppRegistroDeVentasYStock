using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace Datos
{
    public class ConexionDB
    {
        private MySqlConnection conexion;
        private MySqlCommand comando;
        private MySqlDataReader lector;
        
        public MySqlDataReader Lector
        {
            get { return lector; }
        }

        public ConexionDB()
        {
            string cadena = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
            conexion = new MySqlConnection(cadena);
            comando = new MySqlCommand();
        }
        
    

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void cerrarConexion()
        {
            if (lector != null) {
                lector.Close();
            conexion.Close();
            }

        }
    }
}
