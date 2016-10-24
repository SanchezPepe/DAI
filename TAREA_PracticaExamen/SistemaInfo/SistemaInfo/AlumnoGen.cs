using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInfo
{
    class AlumnoGen
    {
        public static bool agrega(Alumno a)
        {
            bool resp = false;
            SqlConnection con = Conexion.agregaConexion();
            String query = "INSERT INTO alumno VALUES ('" + a.nombre + "','" + a.sexo + "','" + a.fechaN + "','" + a.correo + "'," + a.grado + "," + a.programa + ")";
            SqlCommand cmd = new SqlCommand(query, con);
            if (cmd.ExecuteNonQuery() > 0)
                resp = true;
            con.Close();
            return resp;
        }

        public static bool eliminar(String nombre)
        {
            bool resp = false;
            String query = "DELETE FROM alumno WHERE nombre LIKE ' " + nombre + "'";
            SqlConnection con = Conexion.agregaConexion();
            SqlCommand cmd = new SqlCommand(query, con);
            if (cmd.ExecuteNonQuery() > 0)
                resp = true;
            con.Close();
            return resp;
        }

        public static bool modificar(Alumno a, String correoN)
        {
            bool resp = false;
            String query = "UPDATE alumno SET correo = '" + correoN + "' WHERE nombre LIKE '" + a.nombre + "'";
            SqlConnection con = Conexion.agregaConexion();
            SqlCommand cmd = new SqlCommand(query, con);
            if (cmd.ExecuteNonQuery() > 0)
                resp = true;
            con.Close();
            return resp;
        }

    }
}
