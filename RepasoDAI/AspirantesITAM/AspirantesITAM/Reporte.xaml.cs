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

namespace AspirantesITAM
{
    /// <summary>
    /// Lógica de interacción para Reporte.xaml
    /// </summary>
    public partial class Reporte : Window
    {
        public Reporte()
        {
            InitializeComponent();
            Conexion c = new Conexion();
            c.llenaProg(cbPro);
        }

        private void btReporte_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)rbCarrera.IsChecked)
            {
                datos.ItemsSource = AspiranteG.reporteCarrera(cbPro.Text);
            }
            if ((bool)rbTdos.IsChecked)
            {
                datos.ItemsSource = AspiranteG.reporteTodos();
            }

        }
    }
}
