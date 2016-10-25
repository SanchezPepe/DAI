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
    /// Lógica de interacción para Busca.xaml
    /// </summary>
    public partial class Busca : Window
    {
        public Busca()
        {
            InitializeComponent();
        }

        private void btRegresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            this.Hide();
        }

        private void btBuscar_Click(object sender, RoutedEventArgs e)
        {
            dgDatos.ItemsSource = AlumnoGen.buscar(tbNombre.Text); 
        }
    }
}
