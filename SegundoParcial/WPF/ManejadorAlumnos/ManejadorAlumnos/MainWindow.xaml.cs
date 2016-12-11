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
            cbSexo.Items.Add('H');
            cbSexo.Items.Add('M');
        }

        private void btAgregar_Click(object sender, RoutedEventArgs e) {
            Alumno a = new Alumno(tbNombre.Text, cbSexo.Text, tbCorreo.Text, int.Parse(tbSemestre.Text), cbProgramas.Text);
            int res = AlumnoG.agregarAlumno(a);
            if (res != -1)
                MessageBox.Show("Alta de alumno exitosa, clave única: " + res); 
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
