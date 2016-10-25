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
    /// Lógica de interacción para Elimina.xaml
    /// </summary>
    public partial class Elimina : Window
    {
        public Elimina()
        {
            InitializeComponent();
        }

        private void btElimina_Click(object sender, RoutedEventArgs e)
        {
            bool resp = AlumnoGen.eliminar(TBCorreo.Text);
            if (resp)
                MessageBox.Show("Baja de alumno exitosa");
            else
                MessageBox.Show("No se pudo dar de baja al alumno");
        }

        private void btRegresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            this.Hide();
        }
    }
}
