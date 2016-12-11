using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace IngenieriaItam{

    class Conexion{

        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexion() {
            try{
                cnn = new SqlConnection("Data Source=DESKTOP-TR4IJ0I;Initial Catalog=IngenieriaITAM;User ID=sa;Password=sqladmin");
                cnn.Open();
                MessageBox.Show("Conexión realizada con éxito");
            }
            catch(Exception ex){
                MessageBox.Show("No se realizó a conexión " + ex);
            }
        }

        public void llenarComboProgramas(ComboBox cb) {
            try {
                cmd = new SqlCommand("SELECT p.nombre FROM Programas p", cnn);
                dr = cmd.ExecuteReader();

                while (dr.Read()) {
                    cb.Items.Add(dr["nombre"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("No se pudo hacer la lectura " + ex);
            }
        }

    }
}
