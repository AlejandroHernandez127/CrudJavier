using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


namespace OperadoresAplicacion.services
{
    public class Operadores
    {
        private SqlCommand command = null;

        public void CreateOperadores(
            string Nombre, 
            int Edad, 
            int Salario, 
            DateTime Fecha_Nacimiento,
            int IdEmpresa)
        {
            try
            {
                command = new SqlCommand("nameStoreProcedure", Data.ConnectionDB.GetConnection());
                command.CommandType = System.Data.CommandType.StoredProcedure;
                //command = "@accion" + 'Create'
                //      = 

                //parameters
                command.Parameters.AddRange(new SqlParameter[]
                {
                  new SqlParameter("@Nombre", Nombre),
                  new SqlParameter("@Edad", Edad),
                  new SqlParameter("@Salario", Salario),
                  new SqlParameter("@Fecha_Nacimiento", Fecha_Nacimiento),
                  new SqlParameter("@IdEmpresa", IdEmpresa)
                });

                //Execute
                command.ExecuteNonQuery();

            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}