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

namespace SegundoParcial
{
    /// <summary>
    /// Lógica de interacción para Confirmacion.xaml
    /// </summary>
    public partial class Confirmacion : Window
    {
        public Confirmacion()
        {
            InitializeComponent();
            tba.Text = "6484";
            tbc.Text = "7498416";
        }


        private void btregresar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow a = new MainWindow();
            a.Show();

        }


    }
}
