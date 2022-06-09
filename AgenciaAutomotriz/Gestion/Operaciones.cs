using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaAutomotriz.Gestion
{
    public class Operaciones
    {
        public string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AgenciaAutomotriz; Integrated Security = True";
        // Metodo para borrar registros
        public bool IniciarSesion(string usuario, string password)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("IniciarSesion", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Usuario", usuario);
                cmd.Parameters.AddWithValue("Password", password);

                int resp = (int)cmd.ExecuteScalar();
                if (resp > 0)
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
}
