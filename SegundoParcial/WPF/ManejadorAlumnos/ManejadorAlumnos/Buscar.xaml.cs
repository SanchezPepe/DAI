using System;
using System.Collections.Generic;
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

namespace ManejadorAlumnos {
    /// <summary>
    /// Lógica de interacción para Buscar.xaml
    /// </summary>
    public partial class Buscar : Window {
        public Buscar() {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, RoutedEventArgs e) {
            dgDatos.ItemsSource = AlumnoG.buscarAlumno(tbNombre.Text); 
        }

        private void btRegresar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow w = new MainWindow();
            w.Show();
        }
    }
}
