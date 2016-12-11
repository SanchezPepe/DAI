using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace ManejadorAlumnos {
    class Conexion {

        SqlCommand cmd;
        SqlDataReader dr;

        public static SqlConnection agregarConexion() {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-TR4IJ0I;Initial Catalog=IngenieriaITAM;User ID=sa;Password=sqladmin");
            cnn.Open();
            MessageBox.Show("Conexión realizada con éxito");
            return cnn;
        }

        public void llenarCombo(ComboBox cb) {
            try {
                SqlConnection c = Conexion.agregarConexion();
                cmd = new SqlCommand("SELECT p.nombre FROM Programas p", c);
                dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    cb.Items.Add(dr["nombre"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            } catch (Exception e) {
                MessageBox.Show("Error" + e);
            }
        }

    }
}
