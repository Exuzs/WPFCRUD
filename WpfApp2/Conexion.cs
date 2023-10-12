using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class Conexion
    {
        private string connectionString;

        public Conexion()
        {
            connectionString = "Server=DESKTOP-NA16IIF\\SQLEXPRESS;Database=usuariosCRUD;Integrated Security=True;";
        }

        public SqlConnection AbrirConexion()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CerrarConexion(SqlConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
