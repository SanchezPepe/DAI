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

namespace SistemaInfo
{
    /// <summary>
    /// Lógica de interacción para Modifica.xaml
    /// </summary>
    public partial class Modifica : Window
    {
        public Modifica()
        {
            InitializeComponent();
        }

        private void btModifica_Click(object sender, RoutedEventArgs e)
        {
            Alumno a = new Alumno(tbnombre.Text, tbCorreo.Text);
            bool resp = AlumnoGen.modificar(a);
            if (resp)
                MessageBox.Show("Modificación de datos exitosa");
            else
                MessageBox.Show("No se pudo modificar");
        }

        private void btRegresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            this.Hide();
        }
    }
}
