using AgenciaAutomotriz.Modelos;
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

        public List<Automovil> ConsultarPorColor(string parm)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("ConsultarPorColor", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Color", parm);

                //var resp = cmd.ExecuteScalar();
                SqlDataReader reader = cmd.ExecuteReader();

                List<Automovil> automoviles = new List<Automovil>();
                int id = 0;
                string marca = "";
                string modelo = "";
                string tipo = "";
                string color = "";

                while (reader.Read())
                {
                    id = (int)reader[0];
                    marca = reader[1].ToString();
                    modelo = reader[2].ToString();
                    tipo = reader[3].ToString();
                    color = reader[4].ToString();

                    Automovil automovil = new Automovil() { Id = id, Marca = marca, Modelo = modelo, Tipo = tipo, Color = color };
                    automoviles.Add(automovil);
                }

                reader.Close();
                return automoviles;
            }
        }

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
