using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace AspirantesITAM
{
    class Conexion
    {
        SqlCommand cmd;
        SqlDataReader dr;

        public static SqlConnection agregaConexion()
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-TR4IJ0I;Initial Catalog=AspirantesITAM;Persist Security Info=True;User ID=sa;Password=sqladmin");
            cnn.Open();
            return cnn;
        }

        public void llenaProg(ComboBox cb)
        {
            try
            {
                SqlConnection cnn = agregaConexion();
                String query = "SELECT nombre FROM carrera";
                cmd = new SqlCommand(query, cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["nombre"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo llenar CB");
            }
        }
    }
}
