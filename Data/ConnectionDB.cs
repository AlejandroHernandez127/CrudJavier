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
                    string cnx = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                    connection = new SqlConnection(cnx);
                    connection.Open();
                }
                return connection;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void ClaseConnection()
        {
            try
            {
                connection.Close();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

    }
}