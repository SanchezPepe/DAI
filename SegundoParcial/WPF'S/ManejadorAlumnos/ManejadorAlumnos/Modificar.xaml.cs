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
    /// Lógica de interacción para Modificar.xaml
    /// </summary>
    public partial class Modificar : Window {
        public Modificar() {
            InitializeComponent();
        }

        private void btModificar_Click(object sender, RoutedEventArgs e) {
            Alumno a = new Alumno(int.Parse(tbFolio.Text), tbCorreo.Text);
            bool resp = AlumnoG.modificarAlumno(a);
            if (resp)
                MessageBox.Show("Modificación de datos exitosa");
            else
                MessageBox.Show("Error garrafal");
        }
    }
}
