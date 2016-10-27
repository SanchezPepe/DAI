using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SistemaInfo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            Conexion c = new Conexion();
            c.llenaCbProg(CBProgramas);
        }

        private void BTAlta_Click(object sender, RoutedEventArgs e)
        {
            int var = -1;
            bool bandera = true;
            SqlDataReader dr;
            SqlConnection con;

            try
            {
                con = Conexion.agregaConexion();
                SqlCommand cmd = new SqlCommand("SELECT nombreP, idUnico FROM programa", con);
                dr = cmd.ExecuteReader();
                while (dr.Read() && bandera)
                {
                    if (dr.GetString(0) == CBProgramas.Text)
                    {
                        var = dr.GetInt32(1);
                        bandera = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo hacer la lectura " + ex);
            }
            if (TBNombre.Text == "")
                MessageBox.Show("Ingrese datos");
            else
            {
                Alumno a = new Alumno(TBNombre.Text, TBSexo.Text[0], TBFechaNac.Text, TBCorreo.Text, int.Parse(TBGrado.Text), var);
                bool res = AlumnoGen.agrega(a);
                if (res)
                    MessageBox.Show("Alta de alumno exitosa");
                else
                    MessageBox.Show("No se pudo dar de alta al alumno");
            }
        }

        private void BTModifica_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Modifica w = new Modifica();
            w.Show();
        }


        private void BTElimina_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Elimina w = new Elimina();
            w.Show();
        }

        private void BTAspirante_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Aspirante a = new Aspirante();
            a.Show();
        }

        private void BTReporte_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Reporte p = new Reporte();
            p.Show();
        }


    }
}
