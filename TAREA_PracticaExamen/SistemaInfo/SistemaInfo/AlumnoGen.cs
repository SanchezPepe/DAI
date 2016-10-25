using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
            String query = "DELETE FROM alumno WHERE correo LIKE '" + nombre + "'";
            MessageBox.Show(query);
            SqlConnection con = Conexion.agregaConexion();
            SqlCommand cmd = new SqlCommand(query, con);
            if (cmd.ExecuteNonQuery() > 0)
                resp = true;
            con.Close();
            return resp;
        }

        public static bool modificar(Alumno a)
        {
            bool resp = false;
            String query = "UPDATE alumno SET correo = '" + a.correo + "' WHERE nombre LIKE '" + a.nombre + "'";
            SqlConnection con = Conexion.agregaConexion();
            SqlCommand cmd = new SqlCommand(query, con);
            if (cmd.ExecuteNonQuery() > 0)
                resp = true;
            con.Close();
            return resp;
        }

        public static List<Alumno> buscar(String nombre)
        {
            Alumno a;
            List<Alumno> list = new List<Alumno>();
            SqlConnection con = Conexion.agregaConexion();
            SqlCommand cmd = new SqlCommand(String.Format("SELECT nombre, sexo, fechaN, correo, grado, programa FROM alumno WHERE nombre LIKE '%{0}%'", nombre), con);
            SqlDataReader lec = cmd.ExecuteReader();

            while (lec.Read())
            {
                a = new Alumno();
                a.nombre = lec.GetString(0);
                a.sexo = lec.GetString(1)[0];
                a.fechaN = lec.GetString(2);
                a.correo = lec.GetString(3);
                a.grado = lec.GetInt32(4);
                a.programa = lec.GetInt32(5);
                list.Add(a);
            }
            con.Close();
            return list;

        }

    }
}
