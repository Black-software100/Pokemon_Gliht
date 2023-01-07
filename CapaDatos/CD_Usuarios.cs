using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
namespace CapaDatos
{
    public class CD_Usuarios
    {
        public List<Usuario> Listar()
        {
            List<Usuario> Lista = new List<Usuario>();
            using(SqlConnection Oconexion = new SqlConnection(Conexion.conexion))
            {
                try
                {
                    string query = "SELECT IdUsuario,Documento,NombreCompleto,Clave,Correo,Estado FROM USUARIO";
                   
                    SqlCommand cmd = new SqlCommand (query, Oconexion);
                    cmd.CommandType = CommandType.Text;
                    Oconexion.Open();
                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                Documento = dr["Documento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }
                }catch(Exception ex)
                {
                    Lista = new List<Usuario>();

                }
                return Lista;
            
            }
        }
    }
}
