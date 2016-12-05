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
    /// Lógica de interacción para ConfirmacionExt.xaml
    /// </summary>
    public partial class ConfirmacionExt : Window
    {
        public ConfirmacionExt()
        {
            InitializeComponent();
            tbc.Text = "12345";
            MessageBox.Show("Realizar pago");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Agrega ag = new Agrega();
            ag.Show();
        }
    }
}
