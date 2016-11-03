using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SegundoParcial
{
    class Conexion
    {
        SqlCommand cmd;
        SqlDataReader dr;

        public static SqlConnection agregaConexion()
        {
            SqlConnection cnn = new SqlConnection("Data Source=CC201-14;Initial Catalog=datosIngenieria;User ID=sa;Password=sqladmin");
            cnn.Open();
            return cnn;
        }

        public void llenaCbIng(ComboBox cb)
        {
            try
            {
                SqlConnection c = Conexion.agregaConexion();
                cmd = new SqlCommand("SELECT nombre FROM carrera", c);
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
                MessageBox.Show("Error al llenar CB" + e);
            }
        }

        public void llenaCbUni(ComboBox cb)
        {
            try
            {
                SqlConnection c = Conexion.agregaConexion();
                cmd = new SqlCommand("SELECT nombre FROM universidad", c);
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
                MessageBox.Show("Error al llenar CB" + e);
            }
        }
    }
}
