using Login.modelo;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Login.datos
{
    internal class UsuariosDB
    {
        public static bool guardar (Usuario e) 
        {
        try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO tb_usuarios values ('"+e.Documento+"','"+e.Nombres+"','"+e.Apellidos+"',"+e.Edad+",'"+e.Direccion+"')";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;
                }
                else return false;

                
            }
            catch (Exception ex) { }
            {
                return false;
            }
        }

    }
}
