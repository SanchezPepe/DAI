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
    /// Lógica de interacción para Baja.xaml
    /// </summary>
    public partial class Baja : Window
    {
        public Baja()
        {
            InitializeComponent();
        }

        private void btBaja_Click(object sender, RoutedEventArgs e)
        {
            bool res = AspiranteG.bajaAsp(tbCorreo.Text);
            if (res)
                MessageBox.Show("Se eliminó");
            else
                MessageBox.Show("No se eliminó");
        }
    }
}
