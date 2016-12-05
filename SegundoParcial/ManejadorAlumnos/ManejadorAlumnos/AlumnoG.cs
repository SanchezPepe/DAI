using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace ManejadorAlumnos {
    class AlumnoG {

        public static bool agregarAlumno(Alumno a) {
            bool resp = false;
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO Alumno(folio, nombre, sexo, correo, semestre, ingeniería) VALUES ('{0}','{1}', '{2}', '{3}', '{4}' ,'{5}')", a.folio, a.nombre, a.sexo, a.correo, a.semestre, a.ingenieria),con);
            if (cmd.ExecuteNonQuery() > 0)
                resp = true;
            con.Close();
            return resp;
        }

        public static bool eliminarAlumno(int folio) {
            bool resp = false;
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("DELETE FROM Alumno WHERE folio = '{0}'", folio), con);
            if (cmd.ExecuteNonQuery() > 0)
                resp = true;
            con.Close();
            return resp;
        }

        public static bool modificarAlumno(Alumno a) {
            bool resp = false;
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("UPDATE Alumno SET correo = '{0}' WHERE folio = '{1}'", a.folio, a.correo), con);
            if (cmd.ExecuteNonQuery() > 0)
                resp = true;
            con.Close();
            return resp;
        }

        public static List<Alumno> buscarAlumno(String nombre) {
            Alumno a;
            List <Alumno> list = new List<Alumno>();
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("SELECT folio, nombre, sexo, correo, semestre, ingeniería FROM Alumno WHERE nombre LIKE '%{0}%'", nombre), con);
            SqlDataReader lec = cmd.ExecuteReader();

            while(lec.Read()){
                a = new Alumno();
                a.folio = lec.GetInt32(0);
                a.nombre = lec.GetString(1);
                a.sexo = lec.GetString(2);
                a.correo = lec.GetString(3);
                a.semestre = lec.GetInt32(4);
                a.ingenieria = lec.GetInt32(5);
                list.Add(a);
            }
            MessageBox.Show("Terminó la lista");
            con.Close();
            return list;

        }

    }
}
