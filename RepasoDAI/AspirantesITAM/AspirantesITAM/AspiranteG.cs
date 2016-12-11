using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AspirantesITAM
{
    class AspiranteG
    {

        public static bool altaAspirante(Aspirante a)
        {
            bool resp = false;
            SqlConnection cnn = Conexion.agregaConexion();
            String query = "INSERT INTO aspirante VALUES('" + a.nombre + "','" + a.sexo + "','" + a.fechaNac + "','" + a.correo + "'," + a.grado + ",'" + a.programa + "')";
            SqlCommand cmd = new SqlCommand(query, cnn);
            if (cmd.ExecuteNonQuery() > 0)
                resp = true;
            cnn.Close();
            
            return resp;
        }

        public static bool modifica(String corr, String prog)
        {
            bool resp = false;
            SqlConnection cnn = Conexion.agregaConexion();
            SqlCommand cmd = new SqlCommand("UPDATE aspirante SET ingenieria  = '" + prog + "' WHERE correo LIKE '" + corr + "'", cnn);
            if (cmd.ExecuteNonQuery() > 0)
                resp = true;
            cnn.Close();
            return resp;
        }

        public static List<Aspirante> reporteTodos()
        {
            Aspirante a;
            List<Aspirante> list = new List<Aspirante>();
            SqlConnection con = Conexion.agregaConexion();
            String query = "SELECT * FROM aspirante";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader lec = cmd.ExecuteReader();
            while (lec.Read())
            {
                a = new Aspirante();
                a.nombre = lec.GetString(0);
                a.sexo = lec.GetString(1)[0];
                a.fechaNac = lec.GetString(2);
                a.correo = lec.GetString(3);
                a.grado = lec.GetInt32(4);
                a.programa = lec.GetString(5);
                list.Add(a);
            }
            con.Close();
            return list;
        }

        public static List<Aspirante> reporteCarrera(String carrera)
        {
            Aspirante a;
            List<Aspirante> list = new List<Aspirante>();
            SqlConnection con = Conexion.agregaConexion();
            String query = "SELECT * FROM aspirante WHERE ingenieria LIKE '" + carrera + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader lec = cmd.ExecuteReader();
            while (lec.Read())
            {
                a = new Aspirante();
                a.nombre = lec.GetString(0);
                a.sexo = lec.GetString(1)[0];
                a.fechaNac = lec.GetString(2);
                a.correo = lec.GetString(3);
                a.grado = lec.GetInt32(4);
                a.programa = lec.GetString(5);
                list.Add(a);
            }
            con.Close();
            return list;
        }

        public static bool bajaAsp(String correo)
        {
            bool resp = false;
            SqlConnection con = Conexion.agregaConexion();
            SqlCommand cmd = new SqlCommand("DELETE FROM aspirante WHERE correo LIKE '" + correo + "'", con);
            if (cmd.ExecuteNonQuery() > 0)
                resp = true;
            con.Close();
            return resp;
        }
            


    }
}
