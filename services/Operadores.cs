using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace OperadoresAplicacion.services
{
    public class Operadores
    {


        //Get operadores
        public List<Models.OperadoresApp> GetAllOperadores()
        {

            List<Models.OperadoresApp> operaListEntity = new List<Models.OperadoresApp>();

            SqlCommand cmd = new SqlCommand("SelectOperador", Data.ConnectionDB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            dataAdapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                operaListEntity.Add(new Models.OperadoresApp
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Nombre = dr["Nombre"].ToString(),
                    Edad = Convert.ToInt32(dr["Edad"]),
                    Salario = (int)dr["Salario"],
                    Fecha_Nacimiento = Convert.ToString(dr["Fecha_Nacimiento"]),
                    IdEmpresa = (int)dr["IdEmpresa"],
                    Empresa = new Models.Empresa
                    {
                        Razon_Social = Convert.ToString(dr["Razon_Social"]),
                        Direccion = Convert.ToString(dr["Direccion"])
                    }
                });

            }

            return operaListEntity;

        }

        // Get operador 
        public Models.OperadoresApp GetOperadorById(int Id)
        {

            Models.OperadoresApp operaListEntity = new Models.OperadoresApp();

            SqlCommand cmd = new SqlCommand("GetOperador", Data.ConnectionDB.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param;

            cmd.Parameters.Add(new SqlParameter("@Id", Id));


            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            dataAdapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                operaListEntity = new Models.OperadoresApp
                {
                    Id =Convert.ToInt32(dr["Id"]),
                    Nombre = dr["Nombre"].ToString(),
                    Edad = Convert.ToInt32(dr["Edad"]),
                    Salario = (int)dr["Salario"],
                    Fecha_Nacimiento = Convert.ToString(dr["Fecha_Nacimiento"]),
                    IdEmpresa = (int)dr["IdEmpresa"]
                  
                };

            }

            return operaListEntity;

        }

        //Create operador

        public bool AddOperador(Models.OperadoresApp opera) { 
   
       
                SqlCommand cmd = new SqlCommand("Createoperadores", Data.ConnectionDB.GetConnection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //parameters

            cmd.Parameters.AddWithValue("@Nombre", opera.Nombre);
            cmd.Parameters.AddWithValue("@Edad", opera.Edad);
            cmd.Parameters.AddWithValue("@Salario", opera.Salario);
            cmd.Parameters.AddWithValue("@Fecha_Nacimiento", opera.Fecha_Nacimiento);
            cmd.Parameters.AddWithValue("@IdEmpresa",opera.IdEmpresa);

            int i = cmd.ExecuteNonQuery();

            if(i>= 1){
                return true;
            }
            else
            {
                return false;
            }
              
        }

        //Update operador 
        public bool EditOperador(int Id, Models.OperadoresApp opera)
        {


            SqlCommand cmd = new SqlCommand("EditOperador", Data.ConnectionDB.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);

            //parameters

            cmd.Parameters.AddWithValue("@Nombre", opera.Nombre);
            cmd.Parameters.AddWithValue("@Edad", opera.Edad);
            cmd.Parameters.AddWithValue("@Salario", opera.Salario);
            cmd.Parameters.AddWithValue("@Fecha_Nacimiento",Convert.ToDateTime(opera.Fecha_Nacimiento));
            cmd.Parameters.AddWithValue("@IdEmpresa", opera.IdEmpresa);

            int i = cmd.ExecuteNonQuery();

            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // Delete Operedador
        public bool DeleteOperador(int Id, Models.OperadoresApp opera)
        {


            SqlCommand cmd = new SqlCommand("DeleteOperador", Data.ConnectionDB.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);

            //parameters

            int i = cmd.ExecuteNonQuery();

            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public bool  Elimina(int Id)
        {
            SqlCommand cmd = new SqlCommand("DeleteOperador", Data.ConnectionDB.GetConnection());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);

            //parameters

            int i = cmd.ExecuteNonQuery();

            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}