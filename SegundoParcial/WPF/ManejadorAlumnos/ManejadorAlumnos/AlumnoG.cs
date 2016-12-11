using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace ManejadorAlumnos {
    class AlumnoG {

        public static int agregarAlumno(Alumno a) {
            int resp = -1;
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO alumnos(nombre, sexo, correo, semestre, ingenieria) VALUES ('{0}', '{1}', '{2}', '{3}' ,'{4}')", a.nombre, a.sexo, a.correo, a.semestre, a.ingenieria),con);
            if (cmd.ExecuteNonQuery() > 0){
                cmd = new SqlCommand("SELECT claveU FROM alumnos WHERE nombre LIKE '" + a.nombre + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                resp = dr.GetInt32(0);
            }
            con.Close();
            return resp;
        }

        public static bool eliminarAlumno(int folio) {
            bool resp = false;
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("DELETE FROM alumnos WHERE claveU = '{0}'", folio), con);
            if (cmd.ExecuteNonQuery() > 0)
                resp = true;
            con.Close();
            return resp;
        }

        public static bool modificarAlumno(Alumno a) {
            bool resp = false;
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("UPDATE alumnos SET correo = '{0}' WHERE claveU = '{1}'", a.correo, a.folio), con);
            if (cmd.ExecuteNonQuery() > 0)
                resp = true;
            con.Close();
            return resp;
        }

        public static List<Alumno> buscarAlumno(String nombre) {
            Alumno a;
            List <Alumno> list = new List<Alumno>();
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("SELECT claveU, nombre, sexo, correo, semestre, ingenieria FROM alumnos WHERE nombre LIKE '%{0}%'", nombre), con);
            SqlDataReader lec = cmd.ExecuteReader();
            while(lec.Read()){
                a = new Alumno();
                a.folio = lec.GetInt32(0);
                a.nombre = lec.GetString(1);
                a.sexo = lec.GetString(2);
                a.correo = lec.GetString(3);
                a.semestre = lec.GetInt32(4);
                a.ingenieria = lec.GetString(5);
                list.Add(a);
            }
            MessageBox.Show("Terminó la lista");
            con.Close();
            return list;

        }

    }
}
