using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.datos
{
    internal class Conexion
    {
        SqlConnection con;
        public Conexion ()
        {
            con = new SqlConnection("Server=DESKTOP-085JFEA\\SQLEXPRESS;Database=DB_Usuario;integrated security = true"); 
        }


        public SqlConnection conectar()
        {
            try
            {
                con.Open();
                return con;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool desconectar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
