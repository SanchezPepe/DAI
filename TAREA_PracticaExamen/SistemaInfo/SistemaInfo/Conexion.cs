using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SistemaInfo
{
    class Conexion
    {
        SqlCommand cmd;
        SqlDataReader dr;

        public static SqlConnection agregaConexion()
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-TR4IJ0I;Initial Catalog=SistemaITAM;User ID=sa;Password=sqladmin");
            cnn.Open();
            return cnn;
        }

        public void llenaCbProg(ComboBox cb)
        {
            try
            {
                SqlConnection c = Conexion.agregaConexion();
                cmd = new SqlCommand("SELECT nombreP FROM programa", c);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["nombreP"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al llenar CB" + e);
            }
        }
    }
}
