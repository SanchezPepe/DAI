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
using System.Windows.Shapes;

namespace SistemaInfo
{
    /// <summary>
    /// Lógica de interacción para Aspirante.xaml
    /// </summary>
    public partial class Aspirante : Window
    {
        public Aspirante()
        {
            InitializeComponent();

            SqlDataReader dr;
            SqlConnection con;

            try
            {
                Alumno a;
                List<Alumno> lista = new List<Alumno>();
                String query = "SELECT nombre, sexo, fechaN, correo, grado, ingenieria FROM alumno INNER JOIN programa ON alumno.ingenieria = programa.idUnico";
                con = Conexion.agregaConexion();
                SqlCommand cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    a = new Alumno();
                    a.nombre = dr.GetString(0);
                    a.sexo = dr.GetString(1)[0];
                    a.fechaN = dr.GetString(2);
                    a.correo = dr.GetString(3);
                    a.grado = dr.GetInt32(4);
                    a.programa = dr.GetInt32(5);
                    lista.Add(a);
                }
                GridAs.ItemsSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo hacer la lectura " + ex);
            }
            
        }

        


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            this.Hide();
        }
    }
}
