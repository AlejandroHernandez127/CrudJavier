using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace OperadoresAplicacion.Data
{
    public class ConnectionDB
    {
        private static SqlConnection connection = null;
        private ConnectionDB()
        {

        }
        public static SqlConnection GetConnection()

        {
            try
            {
                if (connection == null)
                {
                    string cnx = ConfigurationManager.ConnectionStrings["AppEntities"].ToString().Split('"')[1];
                    connection = new SqlConnection(cnx);
                    connection.Open();
                }

                return connection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Metodo para cerrar conección
        public static void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}