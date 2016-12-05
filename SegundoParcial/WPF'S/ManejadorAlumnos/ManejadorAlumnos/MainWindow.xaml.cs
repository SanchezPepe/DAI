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

namespace ManejadorAlumnos {
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            Conexion c = new Conexion();
            c.llenarCombo(cbProgramas);
        }

        private void btAgregar_Click(object sender, RoutedEventArgs e) {
            int var = -1;
            bool bandera = true;
            SqlDataReader dr;
            SqlConnection con;

            try {
                con = Conexion.agregarConexion();
                SqlCommand cmd = new SqlCommand("SELECT p.nombrePrograma, p.idPrograma FROM Programas p", con);
                dr = cmd.ExecuteReader();
                while(dr.Read() && bandera){
                    if (dr.GetString(0) == cbProgramas.Text) {
                        var = dr.GetInt32(1);
                        MessageBox.Show("Var es: " + var);
                        bandera = false;
                    }
                }
            } catch(Exception ex){
                MessageBox.Show("No se pudo hacer la lectura " + ex);
            }

            Alumno a = new Alumno(int.Parse(tbFolio.Text), tbNombre.Text, tbSexo.Text, tbCorreo.Text, int.Parse(tbSemestre.Text), var);
            bool res = AlumnoG.agregarAlumno(a);
            if (res) 
                MessageBox.Show("Alta de alumno exitosa"); 
            else 
                MessageBox.Show("No se pudo dar de alta al alumno"); 
        }

        private void btEliminar_Click(object sender, RoutedEventArgs e) {
            this.Hide();
            Baja w = new Baja();
            w.Show();
        }

        private void btModificar_Click(object sender, RoutedEventArgs e) {
            this.Hide();
            Modificar w = new Modificar();
            w.Show();
        }

        private void btBuscar_Click(object sender, RoutedEventArgs e) {
            this.Hide();
            Buscar w = new Buscar();
            w.Show();
        }
    }
}
