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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SegundoParcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTINGE_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Agrega a = new Agrega();
            a.Show();
        }

        private void BTASIST_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Asistentes a = new Asistentes();
            a.Show();
        }


    }
}
